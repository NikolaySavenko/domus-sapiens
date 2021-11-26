using Microsoft.AspNetCore.Mvc;
using FrontendService.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FrontendService.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class Users : ControllerBase
	{
		private readonly PostgresContext _context;

		public Users(PostgresContext context)
		{
			_context = context;
		}

		// GET: api/<Users>
		[HttpGet]
		public IEnumerable<User> Get()
		{
			var ids = new List<Guid>();
			foreach(var user in _context.Users)
			{
				ids.Add(user.UserId);
			}
			return _context.Users;
		}

		// GET api/<Users>/5
		[HttpGet("{id:guid}")]
		public User Get(Guid id)
		{
			return _context.Users.FirstOrDefault(u => u.UserId == id);
		}

		// POST api/<Users>/5
		[HttpPost("{id:guid}")]
		public void Post(Guid id, [FromBody] string value)
		{
			_context.Users.Add(new User { UserId = id });
			_context.SaveChanges();
		}

		// DELETE api/<Users>/5
		[HttpDelete("{id:guid}")]
		public void Delete(Guid id)
		{
			_context.Remove(_context.Users.Where(u => u.UserId == id));
		}
	}
}
