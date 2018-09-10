using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DccyOrigination.Models;
using Microsoft.AspNetCore.Mvc;

namespace DccyOrigination.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index(ResultModel  resultModel)
        {
            return View(resultModel);
        }
    }
}