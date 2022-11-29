using Azure.Core;
using Exercicio2_Api_Web.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Exercicio2_Api_Web.Controllers
{
    [ApiController]
    [Route("Pessoas")]

    public class Api_Controller : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> getAllAsync([FromServices] Context context)
        {
            var pessoas = await context
                .Pessoas
                .AsNoTracking()
                .ToListAsync();
            return pessoas == null ? NotFound() : Ok(pessoas);
        }

        [HttpGet]
        [Route("Pessoas/{id}")]
        public async Task<IActionResult> GetActionAsync([FromServices] Context context, [FromRoute] int id)
        {
            var pessoa = await context
                .Pessoas.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
            return pessoa == null ? NotFound() : Ok(pessoa);
        }

        [HttpPost]
        [Route("pessoas")]
        public async Task<IActionResult> PostAsync([FromServices] Context context, [FromBody] Pessoa pessoa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                await context.Pessoas.AddAsync(pessoa);
                await context.SaveChangesAsync();
                return Created($"Api/pessoas/{pessoa.Id}", pessoa);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("Pessoas/{id}")]

        public async Task<IActionResult> PutAsync([FromServices] Context context, [FromBody] Pessoa pessoa, [FromBody] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Model inválida!");

                var p = await context.Pessoas.FirstOrDefaultAsync(x => x.Id == id);

                if (p == null)
                {
                    return NotFound("Pessoa não encontrada");
                }

                try
                {
                    p.nome = pessoa.nome;

                    context.Pessoas.Update(p);
                    await context.SaveChangesAsync();
                    return Ok(p);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }

        [HttpDelete]
        [Route("pessoas/{id}")]

        public async Task<IActionResult> DeleteAsync([FromServices] Context context, [FromRoute] int id)
        {
            var p = await context.Pessoas.FirstOrDefaultAsync(x => x.Id == id);

            if (p == null)
            {
                return BadRequest("Pessoa deletada.");
            }
            try
            {
                context.Pessoas.Remove(p);
                await context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}  

