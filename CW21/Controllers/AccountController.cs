using CW21.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CW21.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult RegisterPatient()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterPatient(Patient patient)
        {
            return View();
        }
    }
}
