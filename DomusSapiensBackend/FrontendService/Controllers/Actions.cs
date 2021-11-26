using FrontendService.Messages;
using FrontendService.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FrontendService.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class Actions : ControllerBase
	{
		private readonly PostgresContext _context;
		private readonly ILogger _log;

		public Actions(ILogger<Actions> log, PostgresContext context)
		{
			_context = context;
			_log = log;
		}

		// GET: api/<Actions>
		[HttpGet]
		public IEnumerable<ActionActivity> Get()
		{
			return _context.Actions;
		}

		// GET api/<Actions>/5
		[HttpGet("{actionName}")]
		public ActionResult<ActionActivity> Get(string actionName)
		{
			var result = _context.Actions.FirstOrDefault(a => a.ActionActivityName == actionName);
			if (result != null)
			{
				return Ok(result);
			}
			return NotFound();
		}

		// GET api/<Actions>/actionName/Invoke
		[HttpPost("{id:guid}/Invoke")]
		public async Task<ActionResult> InvokeAsync(Guid id, [FromBody] Dictionary<string, string> actionParams)
		{
			var activity = _context.Actions.FirstOrDefault(a => a.ActionActivityId == id);
			if (activity != null)
			{
				var actionMessage = new ActionMessage(activity, actionParams, _log);
				return Ok($"Oh shit! {id} has been triggered(result={await actionMessage.TrySendAsync()})!");
			}
			
			return NotFound();
		}

		// OPTIONS api/<Actions>/actionName/Invoke
		[HttpOptions("{id:guid}/Invoke")]
		public IActionResult InvokeOptionsAsync()
		{
			return Ok();
		}

		// POST api/<Actions>/5
		[HttpPost("{user_id:guid}")]
		public void Post(Guid user_id, [FromBody] string actionName)
		{
			_context.Actions.Add(new ActionActivity { 
				ActionActivityId = Guid.NewGuid(),
				UserId = user_id,
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
