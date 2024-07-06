using Microsoft.AspNetCore.Mvc;
using System;
using prepaControle.Models;
using prepaControle.Data;
namespace prepaControle.Controllers
{
    public class ChambreController : Controller
    {
        private static List<Chambre> chambres = ChambreData.GetChambre();
        public IActionResult Index()
        {
            ViewBag.chambres = chambres;
            return View();
        }
        [HttpGet]
        public IActionResult Ajouter()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ajouter([FromForm] Chambre chambre)
        {
            chambres.Add(chambre);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Modifier(int id)
        {
            Chambre chambre = chambres.Find(lv => lv.Num == id);
            return View(chambre);
        }

        [HttpPost]
        public IActionResult Modifier([FromForm] Chambre chambre)
        {
            Chambre c = chambres.Find(lv => lv.Num == chambre.Num);
            c.Num = chambre.Num;
            c.Type = chambre.Type;
            c.NumEtage = chambre.NumEtage;
            c.DateDebut = chambre.DateDebut;
            c.DateFin = chambre.DateFin;
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Supprimer(int id)
        {
            Chambre chambre = chambres.Find(lv => lv.Num == id);
            chambres.Remove(chambre);
            return RedirectToAction("Index");
        }
    }
}
