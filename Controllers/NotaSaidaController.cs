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
    public class NotaSaidaController : Controller
    {
        private readonly INfSaidaService _NfSaidaService;
        public NotaSaidaController(INfSaidaService notaSaidaService)
        {
            _NfSaidaService = notaSaidaService;
        }
        [HttpGet]
        public async Task<IEnumerable<NfSaida>> GetAllAsync()
        {
            var nfs = await _NfSaidaService.ListAsync();

            return nfs;
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<NfSaida>> GetAtividade(int id)
        {
            var nfs = await _NfSaidaService.FindByIdAsync(id);

            if (nfs == null)
            {
                return NotFound();
            }

            return nfs;
        }
        [HttpGet("GetByUrlSlag/{urlSlag}")]
        public async Task<IEnumerable<NfSaida>> GetByUrlSlag(string urlSlag)
        {
            var nfs = await _NfSaidaService.ListNomes(urlSlag);

            return nfs;
        }

        public async Task AddAsync(NfSaida nfs)
        {
            await _NfSaidaService.AddAsync(nfs);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, NfSaida nfs)
        {
            if (id != nfs.ID)
            {
                return BadRequest();
            }

            try
            {
                _NfSaidaService.Update(nfs);
            }
            catch (DbUpdateConcurrencyException)
            {

            }

            return NoContent();
        }


        [HttpPost]
        public async Task<ActionResult<NfSaida>> PostNfs(NfSaida nfs)
        {

            _NfSaidaService.AddAsync(nfs);

            return CreatedAtAction("Getnfs", new { id = nfs.ID }, nfs);
        }

        // DELETE: api/Departamento/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNfs(int id)
        {
            var nfs = await _NfSaidaService.FindByIdAsync(id);
            if (nfs == null)
            {
                return NotFound();
            }

            _NfSaidaService.Remove(nfs);


            return NoContent();
        }
    }
}
