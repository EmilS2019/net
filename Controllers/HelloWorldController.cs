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

         public IActionResult Welcome(string hello = "hello", bool iam = false)
         {
            return View();
            //  return HtmlEncoder.Default.Encode($"{hello}, youre not {iam}"); 
         }
    }
}