using DoThaiAnh_PIIT_ASM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoThaiAnh_PIIT_ASM.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var account = new Account()
            {
                Username = "thaianhdo",
                Password = "Thaianhdo28041997",
                Email = "anhdtth1908014@fpt.edu.vn",
                Phone = "0914366644",
                Status = AccountStatus.PENDING
            };
            return View("Create", account);
        }

        public ActionResult SubmitAccount(Account account)
        {
            if (ModelState.IsValid)
            {
                return Redirect("List");
            }
            return View("CreateManual", account);
        }

        public ActionResult List()
        {
            var list = new List<Account>()
            {
                new Account()
                {
                    Username = "thaianhdo",
                    Password = "Thaianhdo28041997",
                    Email = "anhdtth1908014@fpt.edu.vn",
                    Phone = "0914366644",
                    Status = AccountStatus.PENDING
                }
            };
            return View("List", list);
        }
    }
}