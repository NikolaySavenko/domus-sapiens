using IoTControlService.Model.DeviceMethods;

namespace IoTControlService.Model.HighLevelAction
{
	public class Actionjob
	{
		public string Name { get; init; }

		public List<IDeviceMethod> Methods { get; init; }
		// TODO Serialization
	}
}
