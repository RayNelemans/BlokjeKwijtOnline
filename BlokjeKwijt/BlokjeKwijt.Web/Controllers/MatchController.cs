﻿using BlokjeKwijt.Data;
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
    }
}
