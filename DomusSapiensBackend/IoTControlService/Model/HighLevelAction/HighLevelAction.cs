using Newtonsoft.Json.Linq;

namespace IoTControlService.Model.HighLevelAction
{
	public class HighLevelAction
	{
		public string Action { get; set; }
		public Guid Device { get; set; }
		public JObject Params { get; set; }
	}
}
