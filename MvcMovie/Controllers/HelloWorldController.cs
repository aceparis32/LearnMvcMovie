using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //REMINDER : all controller who use IActionResult passed to Views

        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        //GET: /HellowWorld/Welcome
        //Requires System.Text.Encodings.Web;
        //GET: /HelloWorld/Welcome/id?parameter or GET: /HelloWorld/Welcome?parameter1&parameter2
        //public string welcome(string name, int id = 1)
        //{
        //    return htmlencoder.default.encode($"this is helloworld/welcome action method with name : " + name + " and id : " + id);
        //}

        //GET: /HelloWorld/Welcome?name=param&numTimes=param
        //numTimes default to 1
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //ViewData dict. obj contains data that will derived to view
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
