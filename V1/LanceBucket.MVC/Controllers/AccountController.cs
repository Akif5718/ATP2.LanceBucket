using ATP2.LanceBucket.Model.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATP2.LanceBucket.MVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Registration()
        {
            var model = new RegistrationModel();
            //sir ei error ta ektu dekhten plzz sir github ta
            //seta to project start krar age bla dorker chilo akhn to prb hte pare
            //github er account e dhuken


            return View();
        }
    }
}