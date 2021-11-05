using IoTControlService.Model.HighLevelAction;

namespace IoTControlService.ServiceBusMessaging
{
	public interface IProcessData
	{
		Task Process(HighLevelAction action);
	}
}