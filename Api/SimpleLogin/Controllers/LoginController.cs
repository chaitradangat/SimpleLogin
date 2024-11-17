using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace SimpleLogin.Controllers
{
    public class LoginController : ControllerBase
    {
        public LoginController()
        {
            
        }

        [HttpGet]
        public IActionResult Login()
        { 
            var result = new ObjectResult(1);

            return Problem();
            //return Ok();
        } 

    }
}
