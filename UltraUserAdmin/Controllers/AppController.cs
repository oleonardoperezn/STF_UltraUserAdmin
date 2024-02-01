using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UltraUserAdmin.Interfaces;
using UltraUserAdmin.Managers;
using UltraUserAdmin.ViewModels;

namespace UltraUserAdmin.Controllers
{
    public class AppController : Controller
    {
        // GET: App
        IAppInterface _mng = new AppManager();
        public ActionResult ResetPass(string appnm)
        {
            ViewBag.Appnm = appnm;

            return View();
        }
        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        public JsonResult ValidateUserMail(string appnm, string user)
        {
            var result = _mng.SendValidateUser(appnm, user);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        public JsonResult GeneratePassSendMail(string appnm, string user, string mail)
        {
            var result = _mng.SendResetPassword(appnm, user, mail);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
    }
}