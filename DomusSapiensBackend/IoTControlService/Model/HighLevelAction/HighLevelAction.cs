namespace IoTControlService.Model.HighLevelAction
{
	public class HighLevelAction
	{
		public string Action { get; set; }
		public Guid Device { get; set; }
		public List<(string, string)> Params { get; set; }
	}
}
