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

		// GET: api/<DbController>
		[HttpGet]
		public IEnumerable<User> Get()
		{
			var ids = new List<int>();
			foreach(var user in _context.Users)
			{
				ids.Add(user.UserId);
			}
			return _context.Users;
		}

		// GET api/<DbController>/5
		[HttpGet("{id}")]
		public User Get(int id)
		{
			return _context.Users.Where(u => u.UserId == id).First();
		}

		// POST api/<DbController>/5
		[HttpPost("{id}")]
		public void Post(int id, [FromBody] string value)
		{
			_context.Users.Add(new User { UserId = id });
			_context.SaveChanges();
		}

		// DELETE api/<DbController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			_context.Remove(_context.Users.Where(u => u.UserId == id));
		}
	}
}
