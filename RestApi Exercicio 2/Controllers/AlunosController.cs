using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestApi_Exercicio_2.DataModels;

namespace RestApi_Exercicio_2.Controllers
{
    [ApiController]
    [Route("api")]
    public class AlunosController : ControllerBase
    {
        //retorna todos os alunos...
        [HttpGet]
        [Route("alunos")]
        public async Task<IActionResult> todosAlunos([FromServices] Context context)
        {
            var aluno = await context.Aluno.AsNoTracking().ToListAsync();

            return aluno == null ? NotFound("Nenhum(a) aluno(a) cadastrado(a)") : Ok(aluno);
        }

        //retorna um aluno especifico...
        [HttpGet]
        [Route("aluno/{id}")]
        public async Task<IActionResult> BuscarAluno([FromServices] Context context, [FromRoute] int id)
        {
            var aluno = await context.Aluno.AsNoTracking().FirstOrDefaultAsync(a => a.id == id);
            return aluno == null ?
                NotFound($"Aluno(a) com ID {id} não encontrado(a)") :
                Ok(aluno);
        }

        //cadastrar alunos...
        [HttpPost]
        [Route("aluno/cadastrar")]
        public async Task<IActionResult> CadastrarAluno([FromServices] Context context, [FromBody] Aluno aluno)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            try
            {
                await context.Aluno.AddAsync(aluno);
                await context.SaveChangesAsync();
                //return Created($"api/alunos/{aluno.id}", aluno);
                return Created($"Aluno(a) '{aluno.nome}' cadastrado(a)!", aluno);
            }            
            catch (Exception ex)
            {               
                return BadRequest($"Erro ao cadastrar o(a) aluno(a) {aluno.id}. Tente novamente mais tarde...");
            }
        }

        //atualizar aluno...
        [HttpPut]
        [Route("aluno/atualizar/{id}")]
        public async Task<IActionResult> AtualizarAluno([FromServices] Context context, [FromBody] Aluno aluno, [FromRoute] int id)
        {
            if (!ModelState.IsValid) return BadRequest("Model inválida");

            var a = await context.Aluno.FirstOrDefaultAsync(a => a.id == id);

            if (a == null) return NotFound("Aluno(a) não encontrado(a)");

            try
            {
                a.nome = aluno.nome;
                a.telefone = aluno.telefone;

                context.Aluno.Update(a);
                await context.SaveChangesAsync();
                return Ok(a);
            }
            catch (Exception ex)
            {
                return BadRequest($"Falha ao atualizar o(a) aluno(a) {a.nome}... Tente novamente mais tarde...");
            }
        }

        //deletar aluno
        [HttpDelete]
        [Route("aluno/excluir/{id}")]
        public async Task<IActionResult> ExcluirAluno([FromServices] Context context, [FromRoute] int id)
        {
            var a = await context.Aluno.FirstOrDefaultAsync(a => a.id == id);

            if (a == null) return BadRequest($"Aluno(a) não encontrado(a)");

            try
            {
                context.Aluno.Remove(a);
                await context.SaveChangesAsync();

                return Ok($"Aluno(a) '{a.nome}' excluído(a) com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao excluir o(a) aluno(a) {a.nome}...");
            }
        }

    }
}