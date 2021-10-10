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

namespace ApiCro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class CaixaRotativoController : Controller
    {
        private readonly ICaixaRotativoServices _caixaRotativoService;
        public CaixaRotativoController(ICaixaRotativoServices caixaRotativoServices)
        {
            _caixaRotativoService = caixaRotativoServices;
        }
        // GET: api/CaixaRotativo
        [HttpGet]
        public async Task<IEnumerable<CaixaRotativo>> GetAllAsync()
        {
            var caixaRotativo = await _caixaRotativoService.ListAsync();

            return caixaRotativo;
        }

        // GET: api/CaixaRotativo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CaixaRotativo>> GetCaixaRotativo(int id)
        {
            var caixaRotativo = await _caixaRotativoService.FindByIdAsync(id);

            if (caixaRotativo == null)
            {
                return NotFound();
            }

            return caixaRotativo;
        }

        // PUT: api/CaixaRotativo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CaixaRotativo caixaRotativo)
        {
            if (id != caixaRotativo.IdCaixaRotativo)
            {
                return BadRequest();
            }

            //_caixaCabService.Entry(caixaCabs).State = EntityState.Modified;

            try
            {
                _caixaRotativoService.Update(caixaRotativo);
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

        [HttpGet("GetByUrlSlag/{urlSlag}")]
        public async Task<IEnumerable<CaixaRotativo>> GetByUrlSlag(string urlSlag)
        {
            var caixaRotativo = await _caixaRotativoService.ListNomes(urlSlag);

            return caixaRotativo;
        }

        [HttpGet("GetBy/{urlID}")]
        public async Task<IEnumerable<CaixaRotativo>> GetBy(int urlID)
        {
            var caixaRotativo = await _caixaRotativoService.ListID(urlID);

            return caixaRotativo;
        }
        [HttpGet("GetSomaBy/{urlID}")]
        public async Task<IEnumerable<CaixaRotativo>> GetSomaBy(int urlID)
        {
            var caixaRotativo = await _caixaRotativoService.ListSomaID(urlID);

            return caixaRotativo;
        }
        [HttpPost]
        public async Task<ActionResult<CaixaCab>> PostCaixaRotativo(CaixaRotativo caixaRotativo)
        {

            _caixaRotativoService.AddAsync(caixaRotativo);

            return CreatedAtAction("GetCaixaRotativo", new { id = caixaRotativo.IdCaixaRotativo }, caixaRotativo);
        }

        // DELETE: api/CaixaRotativo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCaixaRotativo(int id)
        {
            var caixaRotativo = await _caixaRotativoService.FindByIdAsync(id);
            if (caixaRotativo == null)
            {
                return NotFound();
            }

            _caixaRotativoService.Remove(caixaRotativo);


            return NoContent();
        }

       

       
    }
}
