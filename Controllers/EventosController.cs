using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SICORA.Models;

namespace SICORA.Controllers
{
    public class EventosController : Controller
    {
        public IActionResult Mostrar_Eventos()
        {
            return View();
        } 

    }
}