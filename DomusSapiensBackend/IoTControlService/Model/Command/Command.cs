using IoTControlService.Model.DeviceMethods;
using Microsoft.Azure.Devices;
using Newtonsoft.Json;

namespace IoTControlService.Model.Command
{
	// Pattern Command
	public class Command : IExecutable
	{
		public List<IDeviceMethod> _methods { get; set; }
		public Guid DeviceId { get; init; }
		private string targetDevice = "test-device";// DeviceId in future

		private string _connectionString = Environment.GetEnvironmentVariable("IoTHubConnectionString");

		public async Task ExecuteAsync()
		{
			using (var serviceClient = ServiceClient.CreateFromConnectionString(_connectionString))
			{
				foreach (var method in _methods)
				{
					var deviceMethod = new CloudToDeviceMethod(method.Name);
					var payload = JsonConvert.SerializeObject(method.Params);
					deviceMethod.SetPayloadJson(payload);
					await serviceClient.InvokeDeviceMethodAsync(targetDevice, deviceMethod);
				}
			}
			
		}
	}
}
