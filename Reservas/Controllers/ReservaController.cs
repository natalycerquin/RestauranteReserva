using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reservas.Controllers
{
    public class ReservaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
