using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;

namespace HighWall.Web.ApiControllers
{
    [ApiController]
    [Route("api/Capi")]
    public class CapitalismController : ControllerBase
    {
        [HttpGet("hello")]
        public ActionResult Hello()
        {
            var helloResponse = new HelloResponse();
            helloResponse.Msg = "Hello, Human";


            return Ok(JsonConvert.SerializeObject(helloResponse));
        }
        
        [HttpPost("bello")]
        public string Bello()
        {
            return "Bello, Human";
        }
    }

    public class HelloResponse
    {
        public string Msg;
    }
}