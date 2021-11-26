namespace IoTControlService.Model.DeviceMethods
{
	public interface IDeviceMethod
	{
		public string Name { get; init; }

		public Dictionary<string, string> Params { get; init; }
	}
}
