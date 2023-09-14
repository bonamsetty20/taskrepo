using Microsoft.AspNetCore.Mvc;
using WebAppUsers.Models;

namespace WebAppUsers.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>
        {
new User(){UserId=1,UserName="sam",UserPwd="sam@1256",UserEmail="sam@yahoo.com"},
new User(){UserId=2,UserName="anish",UserPwd="anish@1256",UserEmail="anish@yahoo.com"},
new User(){UserId=3,UserName="vasanth",UserPwd="vasanth@1256",UserEmail="vasanth@yahoo.com"},
new User(){UserId=4,UserName="ravi",UserPwd="ravi@1256",UserEmail="ravi@yahoo.com"},
        };
        public IActionResult Index()
        {
            return View(users);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new User());
        }
        [HttpPost]
        public IActionResult Create(User model)
        {
            if (ModelState.IsValid)
            {
                users.Add(model);

                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }

        }

    }
}

