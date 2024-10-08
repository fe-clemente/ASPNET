﻿using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [ApiController]
    [Route ( template:"") ]
    public class HomeController : ControllerBase
    {

    [HttpGet("")]
    public IActionResult Get(
    [FromServices]IConfiguration config)
    {

     var env = config.GetValue<string>("Env");
    return Ok( new {
        environment = env});
    }



    }

   
        
}