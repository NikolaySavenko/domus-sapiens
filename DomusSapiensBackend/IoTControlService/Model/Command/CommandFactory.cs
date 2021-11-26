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
			// test actions will have name GPIO_0_SET_0
			var data = action.Action.Split('_');
			var pin = action.Params.ContainsKey("pin") ? action.Params["pin"] : data[1];
			var value = action.Params.ContainsKey("value") ? action.Params["value"] : data[3];
			Actionjob job = new Actionjob { Name = "JobFromDB", Methods = new List<IDeviceMethod>() {
				new GPIOSwitch(pin, value)
			} };

			_executable._methods = job.Methods;
			return _executable;
		}
	}
}
