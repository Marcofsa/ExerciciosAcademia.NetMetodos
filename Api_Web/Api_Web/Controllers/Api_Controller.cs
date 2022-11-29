using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Primeira_Aplica��o_Web.Controllers
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
        [HttpPost("retornaNome/{nome}")]
        public string PegaNome([FromRoute] string nome)
        {
            return nome;
        }
        [HttpPost("retornIdade/{idade}")]
        public int PegaIdade([FromRoute] int idade)
        {
            return idade;
        }
    }
}