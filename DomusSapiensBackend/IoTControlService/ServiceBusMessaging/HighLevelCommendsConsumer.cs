using Azure.Messaging.ServiceBus;
using IoTControlService.Model.HighLevelAction;

namespace IoTControlService.ServiceBusMessaging
{
	public class HighLevelCommendsConsumer : IHostedService
	{
		private readonly ServiceBusClient _client;
		private readonly IProcessData _processData;
		private readonly IConfiguration _configuration;
		private const string QUEUE_NAME = "iot-service-high-level-commands-input";
		private readonly ILogger _logger;
		private ServiceBusProcessor _processor;

		public HighLevelCommendsConsumer(IProcessData processData,
			IConfiguration configuration,
			ILogger<IoTQueueConsumer> logger)
		{
			_processData = processData;
			_configuration = configuration;
			_logger = logger;

			var connectionString = Environment.GetEnvironmentVariable("ServiceBusConnectionString");
			_client = new ServiceBusClient(connectionString);
		}

		public async Task RegisterOnMessageHandlerAndReceiveMessages()
		{
			ServiceBusProcessorOptions _serviceBusProcessorOptions = new ServiceBusProcessorOptions
			{
				MaxConcurrentCalls = 1,
				AutoCompleteMessages = false,
			};

			_processor = _client.CreateProcessor(QUEUE_NAME, _serviceBusProcessorOptions);
			_processor.ProcessMessageAsync += ProcessMessagesAsync;
			_processor.ProcessErrorAsync += ProcessErrorAsync;
			await _processor.StartProcessingAsync().ConfigureAwait(false);
		}

		private Task ProcessErrorAsync(ProcessErrorEventArgs arg)
		{
			_logger.LogError(arg.Exception, "Message handler encountered an exception");
			_logger.LogDebug($"- ErrorSource: {arg.ErrorSource}");
			_logger.LogDebug($"- Entity Path: {arg.EntityPath}");
			_logger.LogDebug($"- FullyQualifiedNamespace: {arg.FullyQualifiedNamespace}");

			return Task.CompletedTask;
		}

		private async Task ProcessMessagesAsync(ProcessMessageEventArgs args)
		{
			var action = args.Message.Body.ToObjectFromJson<HighLevelAction>();
			await _processData.Process(action).ConfigureAwait(false);
			await args.CompleteMessageAsync(args.Message).ConfigureAwait(false);
		}

		public async ValueTask DisposeAsync()
		{
			if (_processor != null)
			{
				await _processor.DisposeAsync().ConfigureAwait(false);
			}

			if (_client != null)
			{
				await _client.DisposeAsync().ConfigureAwait(false);
			}
		}

		public async Task CloseQueueAsync()
		{
			await _processor.CloseAsync().ConfigureAwait(false);
		}

		public Task StartAsync(CancellationToken cancellationToken)
		{
			return RegisterOnMessageHandlerAndReceiveMessages();
		}

		public Task StopAsync(CancellationToken cancellationToken)
		{
			return CloseQueueAsync();
		}
	}
}
