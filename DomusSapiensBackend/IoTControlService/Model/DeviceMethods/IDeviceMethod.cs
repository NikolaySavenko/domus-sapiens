namespace IoTControlService.Model.DeviceMethods
{
	public interface IDeviceMethod
	{
		public string Name { get; init; }

		public List<IMethodParam> Params { get; init; }
	}
}
