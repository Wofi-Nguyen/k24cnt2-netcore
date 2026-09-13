using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Validation;
using Nvm_Lesson07.Models.DataModels;

namespace Nvm_Lesson07.Controllers
{
    public class NvmMemberController : Controller
    {
        public IActionResult NvmIndex()
        {
            return View(members);
        }
        public IActionResult GetMember()
        {
            var member = new Member();
            member.id = Guid.NewGuid().ToString();
            member.name = "Test";
            member.fullname = "Testfull";
            member.password = "password";

            return View(member);
        }
        protected static List<Member> members = new List<Member>()
            {
                new Member{id = Guid.NewGuid().ToString(), name = "A", fullname = "Nguyen Van A", password = "123"},
                new Member{id = Guid.NewGuid().ToString(), name = "B", fullname = "Tran Thi B", password = "123"},
                new Member{id = Guid.NewGuid().ToString(), name = "C", fullname = "Le Dinh C", password = "123"},
                new Member{id = Guid.NewGuid().ToString(), name = "D", fullname = "Pham Van D", password = "123"}
            };

        public IActionResult ListMember()
        {
            return View(members);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Member member)
        {
            ModelState.Remove("id");
            if (ModelState.IsValid)
            {
                member.id = Guid.NewGuid().ToString();
                members.Add(member);
                return RedirectToAction(nameof(NvmIndex));
            }
            return View(member);
        }
    }
}
