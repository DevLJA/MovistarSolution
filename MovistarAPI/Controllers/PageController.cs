using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovistarAPI.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Education()
        {
            return View("Educacion");
        }
        
        public IActionResult LaboralExperience()
        {
            return View("ExperienciaLaboral");
        }
        public IActionResult PersonalInformation()
        {
            return View("InformacionPersonal");
        }
    }
}
