using Microsoft.AspNetCore.Mvc;

namespace ErhanTopcu_Resume_Project.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }
    }
}
