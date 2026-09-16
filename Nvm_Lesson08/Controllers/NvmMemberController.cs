using Microsoft.AspNetCore.Mvc;
using Nvm_Lesson08.Models;

namespace Nvm_Lesson08.Controllers
{
    public class NvmMemberController : Controller
    {
        private static List<NvmMember> members = new List<NvmMember>()
        {
            new NvmMember { NvmMemberId = Guid.NewGuid().ToString(), NvmUserName = "A", NvmPassword = "PasswordA" },
            new NvmMember { NvmMemberId = Guid.NewGuid().ToString(), NvmUserName = "B", NvmPassword = "PasswordB" },
            new NvmMember { NvmMemberId = Guid.NewGuid().ToString(), NvmUserName = "C", NvmPassword = "PasswordC" },
        };

        public IActionResult Index()
        {
            return View(members);
        }

        [HttpGet]
        public IActionResult NvmCreate()
        {
            var member = new NvmMember();
            return View(member);
        }
        [HttpPost]
        public IActionResult NvmCreate(NvmMember NvmMember)
        {
            NvmMember.NvmMemberId = Guid.NewGuid().ToString();
            members.Add(NvmMember);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult NvmEdit(string id)
        {
            var member = members.Where(x=>x.NvmMemberId.Equals(id)).FirstOrDefault();
            return View(member);
        }

        [HttpPost]
        public IActionResult NvmEdit(string id, NvmMember NvmMember)
        {
            for (int i = 0; i < members.Count; i++)
            {
                if (members[i].NvmMemberId == id)
                {
                    members[i].NvmUserName = NvmMember.NvmUserName;
                    members[i].NvmPassword = NvmMember.NvmPassword;

                    return RedirectToAction("Index");
                }
           
            }
            return View();
        }

        [HttpGet]
        public IActionResult NvmDetails(string id)
        {
            var member = members.Where(x => x.NvmMemberId.Equals(id)).FirstOrDefault();
            return View(member);
        }

        [HttpGet]
        public IActionResult NvmDelete(string id)
        {
            var member = members.Where(x => x.NvmMemberId.Equals(id)).FirstOrDefault();
            return View(member);
        }

        [HttpPost]
        public IActionResult NvmDeleted(string id)
        {
            foreach (var item in members)
            {
                if (item.NvmMemberId.Equals(id))
                {
                    members.Remove(item);
                    return RedirectToAction("Index");
                }
            }
            return View("NvmDelete");
        }
    }
}
