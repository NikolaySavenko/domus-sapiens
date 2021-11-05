using IoTControlService.Model.DeviceMethods;
using IoTControlService.Model.HighLevelAction;
using Newtonsoft.Json.Linq;

namespace IoTControlService.Model.Command
{
	// Factory Pattern
	public class CommandFactory
	{
		private Command _executable;

		public CommandFactory(Guid deviceId)
		{
			_executable = new Command { DeviceId = deviceId };
		}

		public IExecutable BuildCommand(HighLevelAction.HighLevelAction action)
		{
			//TODO get Actionjob from DB
			Actionjob job = new Actionjob { Name = "JobFromDB", Methods = new List<IDeviceMethod>() {
				new GPIOSwitch(action.Params["pin"].ToString(), action.Params["value"].ToString())
			} };

			_executable._methods = job.Methods;
			return _executable;
		}
	}
}
