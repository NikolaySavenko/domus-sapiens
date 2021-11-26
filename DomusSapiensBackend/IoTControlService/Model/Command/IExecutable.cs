namespace IoTControlService.Model.Command
{
	public interface IExecutable
	{
		public Task ExecuteAsync();
	}
}
