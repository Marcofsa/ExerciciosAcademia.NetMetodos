using Exercicio2_Web_Api_CRUD.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Exercicio2_Web_Api_CRUD.Controllers
{
    [ApiController]
    [Route("Aluno")]
    public class Api_Cadastro : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> getAllAsync([FromServices] Context context)
        {
            var alunos = await context.alunos.AsNoTracking().ToListAsync();
            return alunos == null ? NotFound() : Ok(alunos);
        }

        [HttpGet]
        [Route("Aluno/{id}")]
        public async Task<IActionResult> GetActionAsync([FromServices] Context context, [FromRoute] int id)
        {
            var alunos = await context.alunos.AsNoTracking().FirstOrDefaultAsync(a => a.Id == id);
            return alunos == null ? NotFound() : Ok(alunos);
        }

        [HttpGet]
        public async Task<IActionResult> getAllAsync([FromServices] Context context)
        {
            var matricula = await context.alunos.AsNoTracking().ToListAsync();
            return matricula == null ? NotFound() : Ok(matricula);
        }
    }
}




