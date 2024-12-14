using Blog.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [ApiController]

    public class HomeControler:ControllerBase
    {    //Halth-check
        [HttpGet("/")]
        [ApiKey] // "JÁ ESTÁ VALIDANDO"

        public IActionResult Get()
        {
            return Ok();
        }
    }
}
