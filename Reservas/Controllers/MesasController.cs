using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reservas.Controllers
{
    public class MesasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
