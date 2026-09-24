using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nvm_Lesson09.Models.DataModels;
using Nvm_Lesson09.Models.DataViewModels;

namespace Nvm_Lesson08.Controllers
{
    public class NvmMemberController : Controller
    {
        private static List<NvmMember> members = new List<NvmMember>();
        public ActionResult NvmIndex()
        {
            return View(members);
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NvmMember member)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    
                    return View(member);
                }
                members.Add(member);
                return RedirectToAction(nameof(NvmIndex));
            }
            catch
            {
                return View(member);
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(NvmIndex));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(NvmIndex));
            }
            catch
            {
                return View();
            }
        }
    }
}
