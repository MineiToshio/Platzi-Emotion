using EmotionPlatzi.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmotionPlatzi.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //La viewnbag puede tener cualquir tipo de propiedades
            ViewBag.WelcomeMessage = "Welcome to Platzi Emotion!";
            ViewBag.ValorEntero = 1;
            return View();
        }

        public ActionResult IndexAlt()
        {
            var modelo = new Home();
            modelo.WelcomeMessage = "Here you can see if a picture has happy or sad faces!";
            return View(modelo);
        }
    }
}