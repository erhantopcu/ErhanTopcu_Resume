using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
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
        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();

        }
        [HttpPost]
        public PartialViewResult SendMessage(Message p)
        {
            MessageManager messageManager = new MessageManager(new EfMessageDal());
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Status = true;
            messageManager.TAdd(p);
            return PartialView();

        }
    }
}
