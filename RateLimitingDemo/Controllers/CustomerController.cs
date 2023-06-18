using System;
using Microsoft.AspNetCore.Mvc;

namespace RateLimitingDemo.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CustomerController: ControllerBase
	{
		public CustomerController()
		{
		}
		
		[HttpGet]
		public IActionResult Get()
		{
			return Ok("Hello World, so Yeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeey");
		}
	}
}