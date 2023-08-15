using Microsoft.AspNetCore.Mvc;

namespace WebApplication6.Controllers
{
    public class test : Controller
    {
        [HttpGet]
        [Route("test")]
        public IActionResult Test()
        {
            return Ok("API test successful");
        }
    }
}
