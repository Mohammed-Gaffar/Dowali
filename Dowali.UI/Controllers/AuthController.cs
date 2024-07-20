using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlayApp.Extentions;

namespace Dowali.UI.Controllers
{
    public class AuthController : BaseController
    {
        private readonly IConfiguration _configuration;
        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            foreach (var cookie in Request.Cookies.Keys)
            {
                Response.Cookies.Delete(cookie);
            }

            return Redirect(_configuration.GetSection("FormsAuthentication:Logout").Value);
        }

        [Authorize]
        public IActionResult Login()
        {
            return RedirectToAction("Index", "Services");
        }
    }
}
