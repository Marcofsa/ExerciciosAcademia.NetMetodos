using Microsoft.AspNetCore.Mvc;

namespace Primeira_Aplicação_Web.Controllers
{
    [ApiController]
    [Route("api")]
    public class Api_Controller : ControllerBase
    {
        [HttpGet("Nome")]
        public string RetornaNome()
        {
            return "Marcos";
        }

        [HttpGet("Idade")]
        public int RetornaIdade()
        {
            return 26;
        }    
    }
}