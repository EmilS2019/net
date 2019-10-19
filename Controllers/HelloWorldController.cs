using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace seesharp.Controllers
{
    public class HelloWorldController : Controller
    {   
         public IActionResult Index()
         {
             return View();
         }

         public IActionResult Welcome(string name = "user", int numTimes = 1)
         {
            ViewData["Message"] = $"HIII mr or ms. {name}"; 
            ViewData["NumTimes"] = numTimes;
            return View();
         }
    }
}