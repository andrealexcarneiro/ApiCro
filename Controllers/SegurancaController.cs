using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiCro.Models;
using Microsoft.AspNetCore.Authorization;
using ApiCro.Persistence.Context;
using ApiCro.Domain.Services;

namespace ApiCro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class SegurancaController : Controller
    {
        private readonly ISegurancaService _SegurancaService;
        public SegurancaController(ISegurancaService segurancaService)
        {
            _SegurancaService = segurancaService;
        }
        [HttpGet]
        public async Task<IEnumerable<Seguranca>> GetAllAsync()
        {
            var seguranca = await _SegurancaService.ListAsync();

            return seguranca;
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Seguranca>> GetSeguranca(int id)
        {
            var seguranca = await _SegurancaService.FindByIdAsync(id);

            if (seguranca == null)
            {
                return NotFound();
            }

            return seguranca;
        }
        [HttpGet("GetByUrlSlag/{urlSlag}")]
        public async Task<IEnumerable<Seguranca>> GetByUrlSlag(string urlSlag)
        {
            var seguranca = await _SegurancaService.ListNomes(urlSlag);

            return seguranca;
        }

        public async Task AddAsync(Seguranca seguranca)
        {
            await _SegurancaService.AddAsync(seguranca);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Seguranca seguranca)
        {
            if (id != seguranca.id)
            {
                return BadRequest();
            }

            try
            {
                _SegurancaService.Update(seguranca);
            }
            catch (DbUpdateConcurrencyException)
            {

            }

            return NoContent();
        }


        [HttpPost]
        public async Task<ActionResult<Seguranca>> PostSeguranca(Seguranca seguranca)
        {

            _SegurancaService.AddAsync(seguranca);

            return CreatedAtAction("Getseguranca", new { id = seguranca.id }, seguranca);
        }

        // DELETE: api/Departamento/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSeguranca(int id)
        {
            var seguranca = await _SegurancaService.FindByIdAsync(id);
            if (seguranca == null)
            {
                return NotFound();
            }

            _SegurancaService.Remove(seguranca);


            return NoContent();
        }
    }
}
