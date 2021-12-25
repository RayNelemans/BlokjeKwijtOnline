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

        // GET: OverKwijtController
        public ActionResult Index(string bloknr, string lengte, string breedte, string nopjes)
        {
            List<BlokjeViewModel> blokjeViewModels = new();
            List<Blokje> temp = _repo.FilteredBlokjes(bloknr, lengte, breedte, nopjes);
            temp.ForEach(blokje =>
            blokjeViewModels.Add(ConvertToBlokjeViewModel(blokje)));
            return View(blokjeViewModels);
        }

        //public ActionResult Over()
        //{

        //}

        //public ActionResult Kwijt()
        //{

        //}
    }
}
