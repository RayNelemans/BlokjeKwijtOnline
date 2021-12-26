using BlokjeKwijt.Data;
using BlokjeKwijt.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlokjeKwijt.Web.Controllers
{
    public class BlokjeController : Controller
    {
        private BlokjeKwijtRepo _repo;
        public BlokjeController()
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
                ImageName = blokjeVM.ImageFile.FileName
            };
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

        private void UploadFile(IFormFile ufile)
        {
            if (ufile != null && ufile.Length > 0)
            {
                var fileName = Path.GetFileName(ufile.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Images", fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    ufile.CopyTo(fileStream);
                }
            }
        }
        // GET: BlokjeController
        public ActionResult Index()
        {
            List<BlokjeViewModel> blokjeViewModels = new();
            List<Blokje> temp = _repo.GetBlokjes();
            temp.ForEach(blokje =>
            blokjeViewModels.Add(ConvertToBlokjeViewModel(blokje)));
            return View(blokjeViewModels);
        }

        // GET: BlokjeController/Details/5
        public ActionResult Details(int id)
        {
            return View(ConvertToBlokjeViewModel(_repo.GetSingleBlokje(id)));
        }

        // GET: BlokjeController/Create
        public ActionResult Create()
        {
            BlokjeViewModel blokjeVM = new();
            List<KleurViewModel> list = new();
            _repo.FillColorList().ForEach(k =>
            list.Add(ConvertToKleurViewModel(k)));

            blokjeVM.KleurenLijst = list;
            return View(blokjeVM);
        }

        // POST: BlokjeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BlokjeViewModel blokjeVM)
        {
            try
            {
                UploadFile(blokjeVM.ImageFile);
                _repo.AddBlokje(ConvertToBlokjeData(blokjeVM));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlokjeController/Edit/5
        public ActionResult Edit(int id)
        {
            BlokjeViewModel blokjeVM = ConvertToBlokjeViewModel(_repo.GetSingleBlokje(id));
            List<KleurViewModel> list = new();
            _repo.FillColorList().ForEach(k =>
            list.Add(ConvertToKleurViewModel(k)));

            blokjeVM.KleurenLijst = list;
            return View(blokjeVM);
        }

        // POST: BlokjeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, BlokjeViewModel blokjeVM)
        {
            try
            {
                if(blokjeVM.ImageFile != null)
                {
                    UploadFile(blokjeVM.ImageFile);
                }
                _repo.EditBlokje(ConvertToBlokjeData(blokjeVM));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlokjeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(ConvertToBlokjeViewModel(_repo.GetSingleBlokje(id)));
        }

        // POST: BlokjeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _repo.DeleteBlokje(_repo.GetSingleBlokje(id));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
