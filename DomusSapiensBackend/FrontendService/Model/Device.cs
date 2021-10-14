using System.ComponentModel.DataAnnotations;

namespace FrontendService.Model
{
	public class Device
	{
		[Required]
		public int DeviceId { get; set; }
		[Required]
		public int UserId { get; set; }
	}
}