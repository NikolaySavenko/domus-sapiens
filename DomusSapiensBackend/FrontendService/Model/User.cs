﻿using System.ComponentModel.DataAnnotations;

namespace FrontendService.Model
{
	public class User
	{
		[Required]
		public Guid UserId { get; set; }
		public List<Device> Devices { get; set; }
		public List<ActionActivity> Actions { get; set; }
	}
}
