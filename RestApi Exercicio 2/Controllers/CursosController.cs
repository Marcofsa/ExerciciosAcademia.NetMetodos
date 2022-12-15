using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestApi_Exercicio_2.DataModels;

namespace RestApi_Exercicio_2.Controllers
{
    [ApiController]
    [Route("api")]
    public class CursosController : ControllerBase
    {
        //todos os cursos...
        [HttpGet]
        [Route("cursos")]
        public async Task<IActionResult> todosCursos([FromServices] Context context)
        {
            var curso = await context.Curso.AsNoTracking().ToListAsync();

            return curso == null ? NotFound($"Nenhum curso cadastrado.") : Ok(curso);
        }

        //buscar curso específico...
        [HttpGet]
        [Route("curso/{id}")]
        public async Task<IActionResult> buscarCurso([FromServices] Context context, [FromRoute] int id)
        {
            var curso = await context.Curso.AsNoTracking().FirstOrDefaultAsync(c => c.id == id);

            return curso == null ? NotFound($"O curso com ID {id} não foi encontrado") : Ok(curso);
        }

        //cadastrar um curso...
        [HttpPost]
        [Route("curso/cadastrar")]
        public async Task<IActionResult> CadastrarCurso([FromServices] Context context, [FromBody] Curso curso)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            try
            {
                await context.Curso.AddAsync(curso);
                await context.SaveChangesAsync();
                
                return Created($"Curso '{curso.nome}' cadastrado!", curso);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao cadastrar o curso {curso.nome}. Tente novamente mais tarde...");
            }
        }

        //atualizar curso...
        [HttpPut]
        [Route("curso/atualizar/{id}")]
        public async Task<IActionResult> AtualizarCurso([FromServices] Context context, [FromBody] Curso curso, [FromRoute] int id)
        {
            if (!ModelState.IsValid) return BadRequest("Model inválida");

            var c = await context.Curso.FirstOrDefaultAsync(c => c.id == id);

            if (c == null) return NotFound("Curso não encontrado");

            try
            {
                c.nome = curso.nome;
                c.modulos = curso.modulos;

                context.Curso.Update(c);
                await context.SaveChangesAsync();
                return Ok(c);
            }
            catch (Exception ex)
            {
                return BadRequest($"Falha ao atualizar o curso {c.nome}... Tente novamente mais tarde...");
            }
        }

        //excluir curso
        [HttpDelete]
        [Route("curso/excluir/{id}")]
        public async Task<IActionResult> ExcluirCurso([FromServices] Context context, [FromRoute] int id)
        {
            var c = await context.Curso.FirstOrDefaultAsync(c => c.id == id);

            if (c == null) return BadRequest($"Curso com ID {id} não encontrado");

            try
            {
                context.Curso.Remove(c);
                await context.SaveChangesAsync();

                return Ok($"Curso '{c.nome}' excluído com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao excluir o curso {c.nome}...");
            }
        }

    }
}
