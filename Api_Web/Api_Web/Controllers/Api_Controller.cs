using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Primeira_Aplicação_Web.Controllers
{
    [ApiController]
    [Route("api")]
    public class Api_Controller : ControllerBase
    {
        //HTTP GET

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
        [HttpGet("Nacionalidade")]
        public string ReturnNacionalidade()
        {
            return "Brasil";
        }

        //HTTP POST

        [HttpPost("retornaNome/{Nome}")]
        public string PegaNome([FromRoute] string nome)
        {
            return nome;
        }
        [HttpPost("retornIdade/{Idade}")]
        public int PegaIdade([FromRoute] int idade)
        {
            return idade;
        }
        [HttpPost("nacionalidade/{Nacionalidade}")]

        public string PegaNacionalidade([FromRoute] string nacionalidade)
        {
            return nacionalidade;
        }
    }
}