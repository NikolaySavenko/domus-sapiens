using IoTControlService.Model.DeviceMethods;
using Newtonsoft.Json.Linq;

namespace IoTControlService.Model.HighLevelAction
{
	public class HighLevelAction
	{
		public string Action { get; set; }
		public Guid Device { get; set; }
		public Dictionary<string, string> Params { get; set; }
	}
}
