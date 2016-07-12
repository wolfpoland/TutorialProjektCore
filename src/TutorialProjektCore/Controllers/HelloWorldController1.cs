using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TutorialProjektCore.Controllers
{
    public class HelloWorldController1 : Controller
    {
        // GET: /<controller>/
      /*  public string Index()
        {
            return "To dziala z defaulta";
        }
        */
        public IActionResult Index()
        {
            return View();
        }


        /*
         public string Welcome(string name,int numer=1)
        {
            return HtmlEncoder.Default.Encode($"Witaj {name}, id: {numer}");
        }
        */
        public IActionResult Welcome(string name, int numer = 1)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["numer"] = numer;

            return View();
        }
    }
}
