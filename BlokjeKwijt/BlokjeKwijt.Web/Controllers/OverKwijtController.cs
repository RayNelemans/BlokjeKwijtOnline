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
        private int _blokjeId;
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

        private BlokjesVerzoek ConvertToBlokjeVerzoekData(VerzoekViewModel verzoekVM)
        {
            return new BlokjesVerzoek
            {
                Id = verzoekVM.Id,
                BlokjeId = _blokjeId,
                Email = verzoekVM.Email,
                Naam = verzoekVM.Naam,
                TelefoonNummer = verzoekVM.TelefoonNummer
            };
        }

        // GET: OverKwijtController
        public ActionResult Index(string bloknr, string lengte, string breedte, string nopjes)
        {
            //List<BlokjeViewModel> blokjeViewModels = new();
            //List<Blokje> temp = _repo.FilteredBlokjes(bloknr, lengte, breedte, nopjes);
            //temp.ForEach(blokje =>
            //blokjeViewModels.Add(ConvertToBlokjeViewModel(blokje)));
            //return View(blokjeViewModels);

            VerzoekViewModel verzoekVM = new();
            List<BlokjeViewModel> blokjeViewModels = new();
            List<Blokje> temp = _repo.FilteredBlokjes(bloknr, lengte, breedte, nopjes);
            temp.ForEach(blokje =>
            blokjeViewModels.Add(ConvertToBlokjeViewModel(blokje)));
            verzoekVM.BlokjesList = blokjeViewModels;
            return View(verzoekVM);
        }

        public ActionResult Over(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Over(VerzoekViewModel verzoekVM)
        {
            try
            {
                _repo.Over(ConvertToBlokjeVerzoekData(verzoekVM), verzoekVM.BlokjeId);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //public ActionResult Kwijt(int id)
        //{

        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Kwijt(int id)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
