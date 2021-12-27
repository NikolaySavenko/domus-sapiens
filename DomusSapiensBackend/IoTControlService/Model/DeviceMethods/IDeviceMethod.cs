namespace IoTControlService.Model.DeviceMethods
{
	public interface IDeviceMethod
	{
		public string Name { get; init; }

		public Dictionary<string, int> Params { get; init; }
	}
}
