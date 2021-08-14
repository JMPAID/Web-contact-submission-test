using DevTest1.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevTest1.Controllers
{
    public class ContactSubController : Controller
    {

        dev_test_dbEntities db = new dev_test_dbEntities();

        // GET: ContactSub
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddContact(user model)
        {
            if (ModelState.IsValid)
            {
                user userObj = new user();
                userObj.first_name = model.first_name;
                userObj.last_name = model.last_name;
                userObj.address = model.address;
                userObj.state = model.state;
                userObj.country = model.country;
                userObj.zip_code = model.zip_code;
                userObj.phone_number = model.phone_number;
                userObj.note = model.note;

                db.users.Add(userObj);
                db.SaveChanges();
            }

            ModelState.Clear();

            return View("Index");
        }
    }
}