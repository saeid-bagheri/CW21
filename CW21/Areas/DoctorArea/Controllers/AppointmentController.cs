using CW21.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CW21.Areas.DoctorArea.Controllers
{
    [Area("DoctorArea")]
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Appoinment appointment)
        {
            return View();
        }
    }
}
