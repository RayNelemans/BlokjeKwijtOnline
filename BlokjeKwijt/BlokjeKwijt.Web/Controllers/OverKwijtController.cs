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
    public class OverKwijtController : Controller
    {
        private BlokjeKwijtRepo _repo;
        public OverKwijtController()
        {
            _repo = new();
        }

        private BlokjeViewModel ConvertToBlokjeViewModel(Blokje blokje)
        {
            return new BlokjeViewModel
            {
                Id = blokje.Id,
                BlokNummer = blokje.BlokNummer,
                Lengte = blokje.Lengte,
                Hoogte = (Models.Hoogte)blokje.Hoogte,
                Breedte = blokje.Breedte,
                Nopjes = blokje.Nopjes,
                KleurId = blokje.KleurId,
                ImageName = blokje.ImageName
            };
        }

        private Blokje ConvertToBlokjeData(BlokjeViewModel blokjeVM)
        {
            return new Blokje
            {
                Id = blokjeVM.Id,
                BlokNummer = blokjeVM.BlokNummer,
                Lengte = blokjeVM.Lengte,
                Hoogte = (Data.Hoogte)blokjeVM.Hoogte,
                Breedte = blokjeVM.Breedte,
                Nopjes = blokjeVM.Nopjes,
                KleurId = blokjeVM.KleurId,
                ImageName = blokjeVM.ImageName
            };
        }
        // GET: OverKwijtController
        public ActionResult Index(string bloknr, string lengte, string breedte, string nopjes)
        {
            List<BlokjeViewModel> blokjeViewModels = new();
            List<Blokje> temp = _repo.FilteredBlokjes(bloknr, lengte, breedte, nopjes);
            temp.ForEach(blokje =>
            blokjeViewModels.Add(ConvertToBlokjeViewModel(blokje)));
            return View(blokjeViewModels);
        }

        // GET: OverKwijtController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OverKwijtController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OverKwijtController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OverKwijtController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OverKwijtController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OverKwijtController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OverKwijtController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
