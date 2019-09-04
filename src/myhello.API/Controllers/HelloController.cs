    using Microsoft.AspNetCore.Mvc;

    namespace HelloWebApi.API.Controllers
    {
        [Route("api/[controller]")] // API Path will be http://domainpath/api/Hello 
        public class HelloController : Controller {
            static HelloController() {}

            [HttpGet] // http://domainpath/api/Hello Verb: GET
            public IActionResult GetMessage(){
                return new ObjectResult("Hello ASP .NET Core - Web API");
            }
        }
    }
