using System;
using System.Collections.Generic;
using System.Linq;
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
    public class SegurancaItensController : Controller
    {
        private readonly ISegurancaItensService _SegurancaItensService;
        public SegurancaItensController(ISegurancaItensService segurancaItensService)
        {
            _SegurancaItensService = segurancaItensService;
        }
        [HttpGet]
        public async Task<IEnumerable<SegurancaItens>> GetAllAsync()
        {
            var segurancaItens = await _SegurancaItensService.ListAsync();

            return segurancaItens;
        }

        [HttpGet("GetBy/{urlID},{IDusu}")]
        public async Task<IEnumerable<SegurancaItens>> GetBy(int urlID, int idUsu)
        {
            var segurancaItens = await _SegurancaItensService.ListID(urlID, idUsu);

            return segurancaItens;
        }


        [HttpGet("{id}")]

        public async Task<ActionResult<SegurancaItens>> GetSeguranca(int id)
        {
            var segurancaItens = await _SegurancaItensService.FindByIdAsync(id);

            if (segurancaItens == null)
            {
                return NotFound();
            }

            return segurancaItens;
        }
        [HttpGet("GetByUrlSlag/{urlSlag}")]
        public async Task<IEnumerable<SegurancaItens>> GetByUrlSlag(string urlSlag)
        {
            var segurancaItens = await _SegurancaItensService.ListNomes(urlSlag);

            return segurancaItens;
        }

        public async Task AddAsync(SegurancaItens segurancaItens)
        {
            await _SegurancaItensService.AddAsync(segurancaItens);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, SegurancaItens segurancaItens)
        {
            if (id != segurancaItens.Id)
            {
                return BadRequest();
            }

            try
            {
                _SegurancaItensService.Update(segurancaItens);
            }
            catch (DbUpdateConcurrencyException)
            {

            }

            return NoContent();
        }


        [HttpPost]
        public async Task<ActionResult<SegurancaItens>> PostSeguranca(SegurancaItens segurancaItens)
        {

            _SegurancaItensService.AddAsync(segurancaItens);

            return CreatedAtAction("Getseguranca", new { id = segurancaItens.Id }, segurancaItens);
        }

        // DELETE: api/Departamento/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSeguranca(int id)
        {
            var segurancaItens = await _SegurancaItensService.FindByIdAsync(id);
            if (segurancaItens == null)
            {
                return NotFound();
            }

            _SegurancaItensService.Remove(segurancaItens);


            return NoContent();
        }
    }
}
