using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ApiCro.Models;
using Microsoft.AspNetCore.Authorization;
using ApiCro.Persistence.Context;
using ApiCro.Domain.Services;
using ApiCro.Persistence.Repositories;

namespace ApiCro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class CadastroBIController : Controller
    {
        private readonly ICadBIService _cadBIService;
        public CadastroBIController(ICadBIService cadBIService)
        {
            _cadBIService = cadBIService;
        }

        [HttpGet]
        public async Task<IEnumerable<CadastroBI>> GetAllAsync()
        {
            var cadBI = await _cadBIService.ListAsync();

            return cadBI;
        }


        [HttpGet("GetBy/{urlID}")]
        public async Task<IEnumerable<CadastroBI>> GetBy(int urlID)
        {
            var cadastroBI = await _cadBIService.ListID(urlID);

            return cadastroBI;
        }


        [HttpGet("{id}")]

        public async Task<ActionResult<CadastroBI>> GetCadBI(int id)
        {
            var cadBI = await _cadBIService.ListNomesID(id);

            if (cadBI == null)
            {
                return NotFound();
            }

            return NotFound();
        }
        [HttpGet("GetByUrlSlag/{urlSlag}")]
        public async Task<IEnumerable<CadastroBI>> GetByUrlSlag(string urlSlag)
        {
            var cadBI = await _cadBIService.ListNomes(urlSlag);

            return cadBI;
        }

        public async Task AddAsync(CadastroBI cadBI)
        {
            await _cadBIService.AddAsync(cadBI);
        }


        // PUT: api/CaixaCab/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CadastroBI cadBI)
        {
            if (id != cadBI.ID)
            {
                return BadRequest();
            }

            //_caixaCabService.Entry(caixaCabs).State = EntityState.Modified;

            try
            {
                _cadBIService.Update(cadBI);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!CaixaCabExists(id))
                //{
                //    return NotFound();
                //}
                //else
                //{
                //    throw;
                //}
            }

            return NoContent();
        }

        // POST: api/CaixaCab
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CaixaCab>> PostCadBI(CadastroBI cadBI)
        {

            _cadBIService.AddAsync(cadBI);

            return CreatedAtAction("GetCadBI", new { id = cadBI.ID }, cadBI);
        }

        // DELETE: api/CaixaCab/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCadBI(int id)
        {
            var cadBI = await _cadBIService.FindByIdAsync(id);
            if (cadBI == null)
            {
                return NotFound();
            }

            _cadBIService.Remove(cadBI);


            return NoContent();
        }
    }
}
