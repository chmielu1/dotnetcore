using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MySql.Data.MySqlClient;
using System.Data.SqlTypes;
using OPENSHIFT.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            
                return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Kontener DOTNETCORE dla OPENSHIFT";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Napisz do nas";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"czesc {name} to wiadomosc powitalna numer {ID}");
        }
    }
}
