using Microsoft.AspNetCore.Mvc;

namespace ErhanTopcu_Resume_Project.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
