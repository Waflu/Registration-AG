using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Registration.Views.Home;

namespace Registration.Controllers
{
    public class RegistrationController : Controller
    {
      
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Registrations registrations)
        {
            if (ModelState.IsValid)
            {
                return View("Wynik", registrations);
            }
            else return View();
        }
        public IActionResult Wynik(Registrations registrations)
        {
            return View(registrations);
        }
    }
}
