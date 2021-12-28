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
    public class AanvraagController : Controller
    {
        private BlokjeKwijtRepo _repo;

        public AanvraagController()
        {
            _repo = new();
        }

        private AanvraagViewModel ConvertToAanvraagViewModel(Aanvraag aanvraag)
        {
            return new AanvraagViewModel
            {
                Id = aanvraag.Id,
                Naam = aanvraag.Naam,
                TelefoonNummer = aanvraag.TelefoonNummer,
                Email = aanvraag.Email,
                Bericht = aanvraag.Bericht
            };
        }

        private Aanvraag ConvertToAanvraagData(AanvraagViewModel aanvraagVM) 
        {
            return new Aanvraag
            {
                Id = aanvraagVM.Id,
                Naam = aanvraagVM.Naam,
                TelefoonNummer = aanvraagVM.TelefoonNummer,
                Email = aanvraagVM.Email,
                Bericht = aanvraagVM.Bericht
            };
        }

        // GET: AanvraagController
        public ActionResult Index()
        {
            List<AanvraagViewModel> aanvraagVM = new();
            List<Aanvraag> temp = _repo.GetAanvragen();
            temp.ForEach(aanvraag =>
            aanvraagVM.Add(ConvertToAanvraagViewModel(aanvraag)));
            return View(aanvraagVM);
        }

        // GET: AanvraagController/Details/5
        public ActionResult Details(int id)
        {
            return View(ConvertToAanvraagViewModel(_repo.GetSingleAanvraag(id)));
        }

        // GET: AanvraagController/Create
        public ActionResult Create()
        {
            return View(new AanvraagViewModel());
        }

        // POST: AanvraagController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AanvraagViewModel aanvraagVM)
        {
            try
            {
                _repo.AddAanvraag(ConvertToAanvraagData(aanvraagVM));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AanvraagController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(ConvertToAanvraagViewModel(_repo.GetSingleAanvraag(id)));
        }

        // POST: AanvraagController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, AanvraagViewModel aanvraagVM)
        {
            try
            {
                _repo.DeleteAanvraag(_repo.GetSingleAanvraag(id));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
