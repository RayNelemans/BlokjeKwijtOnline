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
    public class MatchController : Controller
    {
        private BlokjeKwijtRepo _repo;

        public MatchController()
        {
            _repo = new();
        }

        private VerzoekViewModel ConvertToVerzoekViewModel(BlokjesVerzoek blokjesVerzoek)
        {
            return new VerzoekViewModel
            {
                Id = blokjesVerzoek.Id,
                BlokjeId = blokjesVerzoek.BlokjeId,
                Naam = blokjesVerzoek.Naam,
                Email = blokjesVerzoek.Email,
                TelefoonNummer = blokjesVerzoek.TelefoonNummer,
                BlokjeOverKwijt = blokjesVerzoek.BlokjeOverKwijt,
                BlokjesVerzoekStatus = blokjesVerzoek.BlokjesVerzoekStatus
            };
        }

        private BlokjesVerzoek ConvertToVerzoekData(VerzoekViewModel verzoekVM)
        {
            return new BlokjesVerzoek
            {
                Id = verzoekVM.Id,
                BlokjeId = verzoekVM.BlokjeId,
                Naam = verzoekVM.Naam,
                Email = verzoekVM.Email,
                TelefoonNummer = verzoekVM.TelefoonNummer,
                BlokjeOverKwijt = verzoekVM.BlokjeOverKwijt,
                BlokjesVerzoekStatus = verzoekVM.BlokjesVerzoekStatus
            };
        }

        // GET: MatchController
        public ActionResult Index()
        {
            MatchViewModel matchVM = new();
            List<VerzoekViewModel> verzoekViewModels = new();
            List<BlokjesVerzoek> temp = _repo.GetVerzoeken();
            temp.ForEach(verzoek =>
            verzoekViewModels.Add(ConvertToVerzoekViewModel(verzoek)));
            matchVM.VerzoekenList = verzoekViewModels;
            return View(matchVM);
        }

        public ActionResult Match(int blokjeId, int kwijtOver)
        {
            MatchViewModel matchVM = new();
            List<VerzoekViewModel> verzoekViewModels = new();
            List<BlokjesVerzoek> temp = _repo.GetVerzoekenWithBlokjeId(blokjeId, kwijtOver);
            temp.ForEach(verzoek =>
            verzoekViewModels.Add(ConvertToVerzoekViewModel(verzoek)));
            matchVM.VerzoekenList = verzoekViewModels;
            return View(matchVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Match(int id, VerzoekViewModel verzoekVM)
        {
            try
            {
                _repo.EditVerzoek(ConvertToVerzoekData(verzoekVM));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
