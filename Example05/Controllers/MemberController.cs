using Example05.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace Example05.Controllers
{
    public class MemberController : Controller
    {
        public static readonly List<Member> members = new List<Member>();

        public IActionResult Index()
        {
            return View(members);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Member member)
        {
           
            if (member.Birthday > DateTime.Now.AddYears(-18))
            {
                ModelState.AddModelError(
                    "Birthday",
                    "Bạn chưa đủ 18 tuổi"
                );
            }

           
            if (!string.IsNullOrEmpty(member.Phone))
            {
                if (!member.Phone.All(char.IsDigit) ||
                    member.Phone.Length < 10 ||
                    member.Phone.Length > 11)
                {
                    ModelState.AddModelError(
                        "Phone",
                        "Số điện thoại không hợp lệ"
                    );
                }
            }

            if (ModelState.IsValid)
            {
                member.MemberId = Guid.NewGuid().ToString();

                members.Add(member);

                return RedirectToAction("Index");
            }

            return View(member);
        }
    }
}