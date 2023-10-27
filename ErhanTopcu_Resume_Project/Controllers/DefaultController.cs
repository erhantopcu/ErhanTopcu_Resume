using Microsoft.AspNetCore.Mvc;

namespace ErhanTopcu_Resume_Project.Controllers
{
    //backend tarafındaki kodları yazıcaz mimaride tanımladığımız kodları burda çağırıcaz ui ile birleştiricez.
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();

        }
        public PartialViewResult NavBarPartial()
        {
            return PartialView();

        }
    }
}
