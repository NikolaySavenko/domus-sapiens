﻿using FrontendService.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FrontendService.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class Actions : ControllerBase
	{
		private readonly PostgresContext _context;

		public Actions(PostgresContext context)
		{
			_context = context;
		}

		// GET: api/<Actions>
		[HttpGet]
		public IEnumerable<ActionActivity> Get()
		{
			return _context.Actions;
		}

		// GET api/<Actions>/5
		[HttpGet("{actionName}")]
		public ActionActivity Get(string actionName)
		{
			return _context.Actions.Where(a => a.ActionActivityName == actionName).First();
		}

		// GET api/<Actions>/actionName/Invoke
		[HttpPost("{id:guid}/Invoke")]
		public string Invoke(Guid id)
		{
			return $"Oh shit! {id} has been triggered!";
		}

		// POST api/<Actions>/5
		[HttpPost("{user_id:guid}")]
		public void Post(Guid id, [FromBody] string actionName)
		{
			_context.Actions.Add(new ActionActivity { 
				ActionActivityId = Guid.NewGuid(),
				UserId = id,
				ActionActivityName = actionName
			});
			_context.SaveChanges();
		}

		// DELETE api/<Actions>/5
		[HttpDelete("{actionName}")]
		public void Delete(string actionName)
		{
			_context.Remove(_context.Actions.Where(a => a.ActionActivityName == actionName));
		}
	}
}
