using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GedHelpDesk.Services;

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
    }
}