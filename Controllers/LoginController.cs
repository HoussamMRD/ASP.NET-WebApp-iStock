using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using iStock.Data;


namespace iStock.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Verify_Credantials(String Username, String Password)
        {
            if (Username == "houssam" && Password == "1234")
            {
                return RedirectToAction("Index", "Fournisseur");
            }
            else
            {

                return RedirectToAction("Index", "Login");
            }

        }
    }
}
