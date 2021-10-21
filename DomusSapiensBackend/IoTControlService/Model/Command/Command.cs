using IoTControlService.Model.DeviceMethods;

namespace IoTControlService.Model.Command
{
	// Pattern Command
	public class Command : IExecutable
	{
		public List<IDeviceMethod> _methods { get; set; }
		public Guid DeviceId { get; init; }

		public void Execute()
		{
			foreach (var method in _methods)
			{
				// TODO send to device
			}
		}
	}
}
