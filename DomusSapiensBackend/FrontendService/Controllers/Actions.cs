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
		public ActionActivity Get(string actionName)
		{
			return _context.Actions.Where(a => a.ActionActivityName == actionName).First();
		}

		// GET api/<Actions>/actionName/Invoke
		[HttpPost("{id:guid}/Invoke")]
		public async Task<string> InvokeAsync(Guid id, [FromBody] JObject actionParams)
		{
			var activity = _context.Actions.Where(a => a.ActionActivityId == id).First();
			var actionMessage = new ActionMessage(activity, actionParams, _log);
			return $"Oh shit! {id} has been triggered(result={await actionMessage.TrySendAsync()})!";
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
