namespace FrontendService.Messages
{
	public interface IMessage
	{
		public Task<bool> TrySendAsync();
	}
}
