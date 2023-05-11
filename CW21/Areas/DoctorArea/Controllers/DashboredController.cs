using Microsoft.AspNetCore.Mvc;

namespace CW21.Areas.DoctorArea.Controllers
{
    [Area("DoctorArea")]
    public class DashboredController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
