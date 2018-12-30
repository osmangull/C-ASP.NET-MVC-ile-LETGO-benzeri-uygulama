using Hackothon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hackothon.Controllers
{
    public class HomeController : Controller
    {
        YzmProjeEntities yzm = new YzmProjeEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hakkimizda()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string kadi, string sifre)
        {
            var k = yzm.Kullanicilar.FirstOrDefault(x => x.kullaniciAdi == kadi && x.parola == sifre);

            return View("Index");
        }

        public ActionResult Kayit()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Kayit(string kadi,string sifre,string eposta)
        {
           // var c = yzm.Kullanicilar.FirstOrDefault(b => b.kullaniciAdi == kadi && b.parola == sifre && b.email == eposta);
            Kullanicilar k = new Kullanicilar();
            k.kullaniciAdi = kadi;
            k.parola = sifre;
            k.email = eposta;
            
            yzm.Kullanicilar.Add(k);
            yzm.SaveChanges();
            return View("Hakkimizda");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}