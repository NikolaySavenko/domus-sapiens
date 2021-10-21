using IoTControlService.Model.HighLevelAction;
using IoTControlService.Model.DeviceMethods;

namespace IoTControlService.Model.Command
{
	// Factory Pattern
	public class CommandFactory
	{
		private Command _executable;

		public CommandFactory(string commandName, Guid deviceId)
		{
			_executable = new Command { DeviceId = deviceId };
		}

		public IExecutable BuildCommand()
		{
			//TODO get Actionjob from redis
			Actionjob job = new Actionjob { Name = "JobFromRedis", Methods = new List<IDeviceMethod>() };

			_executable._methods = job.Methods;
			return _executable;
		}
	}
}
