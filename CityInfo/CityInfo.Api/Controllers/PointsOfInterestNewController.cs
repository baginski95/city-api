using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Api.Controllers
{
    public class PointsOfInterestNewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
