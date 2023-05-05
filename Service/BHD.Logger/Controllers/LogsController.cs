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
    }
}

