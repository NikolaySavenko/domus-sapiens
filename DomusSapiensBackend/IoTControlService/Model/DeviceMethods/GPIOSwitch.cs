namespace IoTControlService.Model.DeviceMethods
{
	public record GPIOSwitch : IDeviceMethod
	{
		public string Name { get; init; }

		public Dictionary<string, string> Params { get; init; }

		public GPIOSwitch(string pin, string value)
		{
			Name = DeviceMethodName.GPIOSwitch;
			// TODO convert from pin name string pin device twin to int
			Params = new Dictionary<string, string>();
			Params.Add("pin", pin);
			Params.Add("value", value);
		}
	}
}
