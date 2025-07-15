using Microsoft.AspNetCore.Mvc;

namespace AgricultureEMS.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}