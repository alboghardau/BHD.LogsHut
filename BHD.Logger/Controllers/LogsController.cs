using System;
using BHD.Logger.Models;
using BHD.Logger.Services;
using Microsoft.AspNetCore.Mvc;

namespace BHD.Logger.Controllers
{
	[Route("api/{controller}/{action}")]
	[ApiController]
	public class LogsController : ControllerBase
	{
		LoggerService loggerService;

		public LogsController(LoggerService loggerService)
		{
			this.loggerService = loggerService;
		}

		[ActionName("GetAllLogs")]
		[HttpGet]
        public IActionResult GetAllLogs()
        {
            return Ok(loggerService.GetAllLogs());
        }

		[ActionName("GetLogsCounter")]
		[HttpGet]
		public IActionResult GetLogsCounter()
		{
			return Ok(loggerService.GetLogsNumber());
		}

        [ActionName("test")]
        [HttpPost]
		public IActionResult Test([FromBody]string text)
		{
            if (text == null)
            {
                return BadRequest("Invalid payload format.");
            }
            // code to handle the received string goes here
            return Ok(text);
        }
    }
}

