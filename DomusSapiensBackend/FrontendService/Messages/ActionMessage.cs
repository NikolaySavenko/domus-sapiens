using FrontendService.Model;
using IoTControlService.Model.HighLevelAction;
using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Logging.Abstractions;
using Newtonsoft.Json;
using System;
using Newtonsoft.Json.Linq;

namespace FrontendService.Messages
{
	public class ActionMessage : IMessage
	{
		private readonly ActionActivity _action;
		private readonly string _connectionString = Environment.GetEnvironmentVariable("ServiceBusConnectionString");

		public string QueueName { get; init; } = "iot-service-high-level-commands-input";
		public ServiceBusMessage Message { get; init; }

		public ILogger Logger { get; init; }

		public ActionMessage(ActionActivity action, Dictionary<string, string> actionParams) : this(action, actionParams,  NullLogger.Instance) { }

		public ActionMessage(ActionActivity action, Dictionary<string, string> actionParams, ILogger logger)
		{
			_action = action;
			Logger = logger;
			// TODO add DeviceId to ActionMessage 
			var hAction = new HighLevelAction { Action = action.ActionActivityName, Device = action.UserId, Params = actionParams };
			Message = new ServiceBusMessage(JsonConvert.SerializeObject(hAction));
		}

		public async Task<bool> TrySendAsync()
		{
			await using var client = new ServiceBusClient(_connectionString);
			await using var sender = client.CreateSender(QueueName);
			using ServiceBusMessageBatch messageBatch = await sender.CreateMessageBatchAsync();
			if (messageBatch.TryAddMessage(Message))
			{
				Logger.LogInformation($"Message {Message.MessageId} to {Message.To} succesfully added");
				try
				{
					Logger.LogInformation($"Try send {Message.MessageId} to {Message.To}");
					await sender.SendMessageAsync(Message);
					return true;
				}
				catch (Exception)
				{
					Logger.LogError($"Failed send {Message.MessageId} to {Message.To} with content {Message}");
					return false;
				}
			} 
			else
			{
				Logger.LogError($"Message {Message.MessageId} to {Message.To} with content {Message} not added added");
			}
			return false;
		}
	}
}
