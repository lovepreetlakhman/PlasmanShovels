using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace PlasmanShovels.Controllers
{
    public class ShovelController : Controller
    {
        

        public string Index()
        {
            return "This is my default action...";
        }

        

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}