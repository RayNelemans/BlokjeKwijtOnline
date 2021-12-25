using BlokjeKwijt.Data;
using BlokjeKwijt.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlokjeKwijt.Web.Controllers
{
    public class KleurController : Controller
    {
        private BlokjeKwijtRepo _repo;

        public KleurController()
        {
            _repo = new();
        }

        private KleurViewModel ConvertToKleurViewModel(Kleur kleur)
        {
            return new KleurViewModel
            {
                Id = kleur.Id,
                KleurNaam = kleur.KleurNaam,
                KleurCode = kleur.KleurCode
            };
        }

        private Kleur ConvertToKleurData(KleurViewModel kleurVM)
        {
            return new Kleur
            {
                Id = kleurVM.Id,
                KleurNaam = kleurVM.KleurNaam,
                KleurCode = kleurVM.KleurCode
            };
        }

        // GET: KleurController
        public ActionResult Index()
        {
            List<KleurViewModel> kleurenViewModels = new();
            List<Kleur> temp = _repo.GetKleuren();
            temp.ForEach(kleur =>
            kleurenViewModels.Add(ConvertToKleurViewModel(kleur)));
            return View(kleurenViewModels);
        }

        // GET: KleurController/Details/5
        public ActionResult Details(int id)
        {
            return View(ConvertToKleurViewModel(_repo.GetSingleKleur(id)));
        }

        // GET: KleurController/Create
        public ActionResult Create()
        {
            return View(new KleurViewModel());
        }

        // POST: KleurController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(KleurViewModel kleurVM)
        {
            try
            {
                _repo.AddKleur(ConvertToKleurData(kleurVM));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KleurController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(ConvertToKleurViewModel(_repo.GetSingleKleur(id)));
        }

        // POST: KleurController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(KleurViewModel kleurVM)
        {
            try
            {
                _repo.EditKleur(ConvertToKleurData(kleurVM));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KleurController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(ConvertToKleurViewModel(_repo.GetSingleKleur(id)));
        }

        // POST: KleurController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, KleurViewModel kleurVM)
        {
            try
            {
                _repo.DeleteKleur(_repo.GetSingleKleur(id));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
