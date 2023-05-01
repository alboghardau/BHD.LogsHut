using System;
using BHD.Logger.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BHD.Logger.Controllers
{
    [Route("api/{controller}/{action}")]
    [ApiController]
    public class MockController : ControllerBase
    {
        IMockService mockService;

        public MockController(IMockService mockService)
        {
            this.mockService = mockService;
        }

        [ActionName("Start")]
        [HttpPost]
        public IActionResult Start()
        {
            this.mockService.Start();
            return Ok("OK");
        }

        [ActionName("Stop")]
        [HttpPost]
        public IActionResult Stop()
        {
            this.mockService.Stop();
            return Ok("OK");
        }
    }
}

