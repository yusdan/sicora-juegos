using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SICORA.Models;

namespace SICORA.Controllers
{
    public class JuegosController : Controller
    {
        public IActionResult Mostrar_Juegos()
        {
            return View();
        } 

    }
}