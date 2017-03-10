using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("[controller]")]
    [Authorize]
    public class IdentityController : Controller
    {
                
        public IActionResult Get()
        {
            return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        }

        [AcceptVerbs("POST", "PUT")]
        public IActionResult Add(string title)
        {
            Console.Write("Inseri titulo");
            return Ok();
        }

    }
}
