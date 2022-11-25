using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {
      /*  public string Index()
        {
            //return View();
            return "minha ação padrão";
        }*/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string nome, int numTimes = 1)
        {
            ViewData["Message"] = "Oi " + nome;
            ViewData["NumTimes"] = numTimes;
            return View();
        }


        public string Welcome2(int id = 0, string nome = "", int vezes = 1)
        {
            return HtmlEncoder.Default.Encode($"Oi {nome}, vezes: {vezes}, id: {id}");
        }
        public double somaDoisValores (int n1 = 0, double n2 = 0)
        {
            return n1 + n2;
        }
    }

}
