using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WatchIt.Models;
namespace WatchIt.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        WatchItEntities2 db = new WatchItEntities2();
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Successful()
        {
            return View();
        }
        public ActionResult SuccessfulAdmin()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public JsonResult CheckUserName()
        {

            string userName = Request["UserName"];
            var usr = (from x in db.Users
                      where (x.UserName == userName) 
                      select x).FirstOrDefault();
            
            bool check;
            if (usr != null)
            {
                check = true;
            }
            else
                check = false;

            return this.Json(check, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        
        public ActionResult Register([Bind(Include = "UserName,Password")]User usr)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(usr);
                db.SaveChanges();
            }
            return View(usr);
        }
        [HttpPost]
        public ActionResult LoginCheck(User us )
        {
            var type= Request["optradio"];
            //User us = new User();
            //us.UserName=Request["email"];
            //us.Password=Request["password"];
            //var usr=db.Users.First(x=>x.UserName==us.UserName && x.Password==us.Password);
            var usr = (from x in db.Users
                      where (x.UserName == us.UserName) && (x.Password == us.Password)
                      select x).FirstOrDefault();
            
            
            if (usr !=null )
            {
                if (type.ToString() == "User")
                {
                    return RedirectToAction("Successful");
                }
                else if(type.ToString() =="Admin")
                {
                    return RedirectToAction("SuccessfulAdmin");
                }
            }
            return RedirectToAction("Login");
            
        }

    }
}
