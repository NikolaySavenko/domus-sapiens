namespace IoTControlService.Model.DeviceMethods
{
	public record GPIOSwitch : IDeviceMethod
	{
		public string Name { get; init; }

		public Dictionary<string, int> Params { get; init; }

		public GPIOSwitch(int pin, int value)
		{
			Name = DeviceMethodName.GPIOSwitch;
			// TODO convert from pin name string pin device twin to int
			Params = new Dictionary<string, int>();
			Params.Add("pin", pin);
			Params.Add("value", value);
		}
	}
}
