namespace IoTControlService.ServiceBusMessaging
{
	public interface IProcessData
	{
		Task Process(MyPayload myPayload);
	}
	public class MyPayload
	{

	}
    public class ProcessData : IProcessData
    {
        private IConfiguration _configuration;

        public ProcessData(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task Process(MyPayload myPayload)
        {
            
        }
    }
}