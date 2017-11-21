using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
//Every public method in a controller is callable as an HTTP endpoint. In the sample above, both methods return a string. Note the comments preceding each method.8 

//    An HTTP endpoint is a targetable URL in the web application, such as http://localhost:1234/HelloWorld, and combines the protocol used: HTTP, the network location of the web server (including the TCP port): localhost:1234 and the target URI HelloWorld.

namespace PiWeb.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
        //// GET: /HelloWorld/
        //public string Index()
        //{
        //    return "this is my default action....";

        //}
       //
       // GET: /HelloWorld/Welcome/
       // Requires using System.Text.Encoding.Web;

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //"this is the Welcome action method..."
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
            //HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");

        }
    }
}
