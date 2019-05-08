using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PaloWeb.Models;

namespace PaloWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Produces("application/ms-word")]
        public IActionResult Exportar(DocumentoViewModel documento)
        {
            try
            {
                var demoDto = new DocumentoViewModel() { Empresa = "Lorem Ipsum", Nome = "Fernanda Leocadio" };
                return Ok(demoDto);
            }
            catch (Exception ex)
            {
                //log the exception
                throw ex;
            }
        }
    }
}
