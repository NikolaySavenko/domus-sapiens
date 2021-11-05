using IoTControlService.Model.Command;
using IoTControlService.Model.HighLevelAction;

namespace IoTControlService.ServiceBusMessaging
{
    public class ProcessData : IProcessData
    {
        private IConfiguration _configuration;
        private ILogger _logger;

		public ProcessData(IConfiguration configuration, ILogger logger)
		{
			_configuration = configuration;
			_logger = logger;
		}

		public async Task Process(HighLevelAction action)
        {
            var factory = new CommandFactory(action.Device);
            var command = factory.BuildCommand(action);
            command.Execute();
        }
    }
}
