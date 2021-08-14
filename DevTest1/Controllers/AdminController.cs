using DevTest1.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevTest1.Controllers
{
    public class AdminController : Controller
    {
        dev_test_dbEntities db = new dev_test_dbEntities();

        // GET: Admin
        public ActionResult Index()
        {
            var res = db.users.ToList();

            return View(res);
        }
    }
}