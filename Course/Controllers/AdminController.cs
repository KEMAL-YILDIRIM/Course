using Course.Data;
using Course.Filters;
using Course.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace Course.Controllers
{

    [Login]
    public class AdminController : Controller
    {
        public List<ArticlesModel> Konular;
        Model db = new Model();

        // GET: Admin
        public ActionResult Index()
        {
            ExamModel model = new ExamModel();
            GetArticles();
            model.Konular = Konular;
            return View(model);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(ExamModel model)
        {
            Exam exdb = examModelToDb(model);

            db.Exam.Add(exdb);
            db.SaveChanges();
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            IEnumerable<Exam> _list;
            _list = db.Exam;
            return View(_list);
        }

        public ActionResult Sil(int id)
        {
            Exam ex = db.Exam.Find(id);
            db.Exam.Remove(ex);
            db.SaveChanges();
            return RedirectToAction("List");
        }

        private void GetArticles()
        {

            string url = "https://www.wired.com/feed/";


            using (var stream = new ModifiedWebClient().OpenRead(url))
            {
                using (var sr = new StreamReader(stream))
                {
                    using (var reader = XmlReader.Create(sr))
                    {
                        Konular = new List<ArticlesModel>();

                        var feed = SyndicationFeed.Load(reader);
                        foreach (var item in feed.Items)
                        {
                            ArticlesModel makale = new ArticlesModel();
                            makale.Baslik = item.Title.Text;
                            makale.KonuUrl = item.Id;
                            Konular.Add(makale);
                        }
                    }
                }
            }
            Konular = Konular.Take(5).ToList();
        }


        public ActionResult GetContent(ArticlesModel makale)
        {
            string _content = "";

            string _url = makale.KonuUrl;

            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(_url);

            //var data = new ModifiedWebClient().DownloadString(_url);
            //var doc = new HtmlDocument();
            //doc.LoadHtml(data);

            var nodes = doc.DocumentNode.SelectNodes("//p");

            foreach (var item in nodes)
            {
                item.FirstChild.RemoveAllChildren();
            }

            foreach (var item in nodes)
            {
                _content = _content + " " + item.InnerText;
            }
            //get content items here

            ExamModel model = new ExamModel();
            GetArticles();
            model.Konular = Konular;
            model.Baslik = makale.Baslik;
            model.Icerik = _content;


            return View("Index", model);
        }

        private static Exam examModelToDb(ExamModel model)
        {
            Exam exdb = new Exam();
            exdb.Baslik = model.Baslik;
            exdb.Icerik = model.Icerik;
            exdb.Tarih = model.Tarih;
            exdb.Cevap1 = model.Cevap1;
            exdb.Cevap1A = model.Cevap1A;
            exdb.Cevap1B = model.Cevap1B;
            exdb.Cevap1C = model.Cevap1C;
            exdb.Cevap1D = model.Cevap1D;
            exdb.Cevap2 = model.Cevap2;
            exdb.Cevap2A = model.Cevap2A;
            exdb.Cevap2B = model.Cevap2B;
            exdb.Cevap2C = model.Cevap2C;
            exdb.Cevap2D = model.Cevap2D;
            exdb.Cevap3 = model.Cevap3;
            exdb.Cevap3A = model.Cevap3A;
            exdb.Cevap3B = model.Cevap3B;
            exdb.Cevap3C = model.Cevap3C;
            exdb.Cevap3D = model.Cevap3D;
            exdb.Cevap4 = model.Cevap4;
            exdb.Cevap4A = model.Cevap4A;
            exdb.Cevap4B = model.Cevap4B;
            exdb.Cevap4C = model.Cevap4C;
            exdb.Cevap4D = model.Cevap4D;
            return exdb;
        }


    }
}