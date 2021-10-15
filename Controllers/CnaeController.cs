using ApiSistema.Domain.Services;
using ApiSistema.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class CnaeController : Controller
    {
        private readonly ICnaeService _CnaeService;
        public CnaeController(ICnaeService cnaeService)
        {
            _CnaeService = cnaeService;
        }
        [HttpGet]
        public async Task<IEnumerable<Cnae>> GetAllAsync()
        {
            var cnaes = await _CnaeService.ListAsync();

            return cnaes;
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Cnae>> GetCnae(int id)
        {
            var cnae = await _CnaeService.FindByIdAsync(id);

            if (cnae == null)
            {
                return NotFound();
            }

            return cnae;
        }
        [HttpGet("GetByUrlSlag/{urlSlag}")]
        public async Task<IEnumerable<Cnae>> GetByUrlSlag(string urlSlag)
        {
            var cnae = await _CnaeService.ListNomes(urlSlag);

            return cnae;
        }

        public async Task AddAsync(Cnae cnae)
        {
            await _CnaeService.AddAsync(cnae);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Cnae cnae)
        {
            if (id != cnae.ID)
            {
                return BadRequest();
            }

            try
            {
                _CnaeService.Update(cnae);
            }
            catch (DbUpdateConcurrencyException)
            {

            }

            return NoContent();
        }


        [HttpPost]
        public async Task<ActionResult<Cnae>> PostAtividade(Cnae cnae)
        {

            _CnaeService.AddAsync(cnae);

            return CreatedAtAction("Getcnae", new { id = cnae.ID }, cnae);
        }

        // DELETE: api/Departamento/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCnae(int id)
        {
            var cnae = await _CnaeService.FindByIdAsync(id);
            if (cnae == null)
            {
                return NotFound();
            }

            _CnaeService.Remove(cnae);


            return NoContent();
        }
    }
}
