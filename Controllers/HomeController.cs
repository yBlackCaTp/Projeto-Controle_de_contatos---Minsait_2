using Microsoft.AspNetCore.Mvc;
using Projeto_Controle_de_contatos___Minsait_2.Models;
using System.Diagnostics;

namespace Projeto_Controle_de_contatos___Minsait_2.Controllers
{
    public class HomeController : Controller
    {
   
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}