using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace iStock.Controllers
{
    public class LogoutController : Controller
    {
        public IActionResult Index()
        {

            return RedirectToAction("Index", "Home");
        }
    }
}
