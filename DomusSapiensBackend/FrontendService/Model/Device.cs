using System.ComponentModel.DataAnnotations;

namespace FrontendService.Model
{
	public class Device
	{
		[Required]
		public Guid DeviceId { get; set; }
		[Required]
		public Guid UserId { get; set; }
	}
}