namespace IoTControlService.Model.DeviceMethods
{
	public record GPIOSwitch : IDeviceMethod
	{
		public string Name { get; init; }

		public List<IMethodParam> Params { get; init; }

		public GPIOSwitch(string pin, string value)
		{
			Name = DeviceMethodName.GPIOSwitch;
			Params = new List<IMethodParam>()
			{
				new MethodParam { 
					Name = pin,
					Value = value
				}
			};
		}
	}
}
