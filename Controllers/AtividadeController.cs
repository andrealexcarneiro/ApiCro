using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiSistema.Models;
using Microsoft.AspNetCore.Authorization;
using ApiSistema.Persistence.Context;
using ApiSistema.Domain.Services;

namespace ApiSistema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class AtividadeController : Controller
    {
        private readonly IAtividadeService _AtividadeService;
        public AtividadeController(IAtividadeService atividadeService)
        {
            _AtividadeService = atividadeService;
        }
        [HttpGet]
        public async Task<IEnumerable<AtividadeEmpresa>> GetAllAsync()
        {
            var atividades = await _AtividadeService.ListAsync();

            return atividades;
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<AtividadeEmpresa>> GetAtividade(int id)
        {
            var atividade = await _AtividadeService.FindByIdAsync(id);

            if (atividade == null)
            {
                return NotFound();
            }

            return atividade;
        }
        [HttpGet("GetByUrlSlag/{urlSlag}")]
        public async Task<IEnumerable<AtividadeEmpresa>> GetByUrlSlag(string urlSlag)
        {
            var atividade = await _AtividadeService.ListNomes(urlSlag);

            return atividade;
        }

        public async Task AddAsync(AtividadeEmpresa atividade)
        {
            await _AtividadeService.AddAsync(atividade);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, AtividadeEmpresa atividade)
        {
            if (id != atividade.ID)
            {
                return BadRequest();
            }

            try
            {
                _AtividadeService.Update(atividade);
            }
            catch (DbUpdateConcurrencyException)
            {

            }

            return NoContent();
        }


        [HttpPost]
        public async Task<ActionResult<AtividadeEmpresa>> PostAtividade(AtividadeEmpresa atividade)
        {

            _AtividadeService.AddAsync(atividade);

            return CreatedAtAction("Getatividade", new { id = atividade.ID }, atividade);
        }

        // DELETE: api/Departamento/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAtividade(int id)
        {
            var atividade = await _AtividadeService.FindByIdAsync(id);
            if (atividade == null)
            {
                return NotFound();
            }

            _AtividadeService.Remove(atividade);


            return NoContent();
        }
    }
}
