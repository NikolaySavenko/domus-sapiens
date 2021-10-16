using System.ComponentModel.DataAnnotations;

namespace FrontendService.Model
{
	public class ActionActivity
	{
		[Required]
		public string ActionActivityId { get; set; }
		[Required]
		public int UserId { get; set; }
		public string ActionActivityName { get; set; }
	}
}
