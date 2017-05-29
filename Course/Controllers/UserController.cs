using Course.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Course.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            Model db = new Model();
            Exam _exam = new Exam();
            _exam = db
                .Exam
                .FirstOrDefault();

            return View(_exam);
        }

        public ActionResult Next(int id)
        {

            Model db = new Model();
            Exam examModel = new Exam();

            var lastExam = db.Exam.ToList();
            int last = lastExam.Last().Id;
            id++;

            for (int i = id; i < last; i++)
            {
                examModel = db
                .Exam
                .Find(i);

                if (examModel != null)
                {
                    return View("Index", examModel);
                }

            }

            return View("Index", examModel);

        }

        [HttpPost]
        public JsonResult AjaxMethod(int id)
        {
            Model db = new Model();
            Exam examModel = new Exam();
            examModel = db.Exam.Find(id);
            return Json(examModel, JsonRequestBehavior.AllowGet);
        }

    }
}