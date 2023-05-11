using Microsoft.AspNetCore.Mvc;

namespace CW21.Areas.DoctorArea.Controllers
{
    public class DashboredController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
