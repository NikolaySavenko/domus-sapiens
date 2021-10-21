using System.ComponentModel.DataAnnotations;

namespace FrontendService.Model
{
	public class ActionActivity
	{
		[Required]
		public Guid ActionActivityId { get; set; }
		[Required]
		public Guid UserId { get; set; }
		public string ActionActivityName { get; set; }
	}
}
