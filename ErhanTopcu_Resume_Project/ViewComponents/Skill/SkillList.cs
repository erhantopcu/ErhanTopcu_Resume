using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ErhanTopcu_Resume_Project.ViewComponents.Skill
{
    public class SkillList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            SkillManager skillManager = new SkillManager(new EfSkillDal());
            var values = skillManager.TGetList();
            return View(values);
        }
    }
}
