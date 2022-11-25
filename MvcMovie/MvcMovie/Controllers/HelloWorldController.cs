using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "Minha ação padrão";
        }

        public string Welcome()
        {
            return "Bem vindo ao meu método de boas vindas ao MVC Controller";
        }
    }
}
