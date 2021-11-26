using IoTControlService.Model.Command;
using IoTControlService.Model.HighLevelAction;

namespace IoTControlService.ServiceBusMessaging
{
    public class ProcessData : IProcessData
    {
        private IConfiguration _configuration;

		public ProcessData(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public async Task Process(HighLevelAction action)
        {
            var factory = new CommandFactory(action.Device);
            var command = factory.BuildCommand(action);
            await command.ExecuteAsync();
        }
    }
}
