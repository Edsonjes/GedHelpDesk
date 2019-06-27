using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GedHelpDesk.Services;
using GedHelpDesk.Models;

namespace GedHelpDesk.Controllers
{
    public class ChamadosController : Controller
    {
        private readonly ChamadosService _ChamadoService;
        public ChamadosController (ChamadosService chamadosService)
        {
            _ChamadoService = chamadosService;
        }
        public IActionResult Index()
        {
            var listaChamados =  _ChamadoService.FidnAll();
            return View(listaChamados);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Chamados chamados)
        {
            _ChamadoService.Insert(chamados);
            return RedirectToAction(nameof(Index));
        }
    }


}