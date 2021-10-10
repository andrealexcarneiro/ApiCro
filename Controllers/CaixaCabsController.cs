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
    public class CaixaCabsController : Controller
    {
        private readonly ICaixaCabService _caixaCabService;
        public CaixaCabsController(ICaixaCabService caixaCabService)
        {
            _caixaCabService = caixaCabService;
        }

        [HttpGet]
        public async Task<IEnumerable<CaixaCab>> GetAllAsync()
        {
            var caixaCabs = await _caixaCabService.ListAsync();
            
            return caixaCabs;
        }
        //GET: api/CaixaCab/5
        [HttpGet("{id}")]

        public async Task<ActionResult<CaixaCab>> GetCaixaCabs(int id)
        {
            var caixaCab = await _caixaCabService.FindByIdAsync(id);

            if (caixaCab == null)
            {
                return NotFound();
            }

            return caixaCab;
        }
        [HttpGet("GetByUrlSlag/{urlSlag}")]
        public async Task<IEnumerable<CaixaCab>> GetByUrlSlag(string urlSlag)
        {
            var caixaCabs = await _caixaCabService.ListNomes(urlSlag);

            return caixaCabs;
        }
        
        public async Task AddAsync(CaixaCab caixacab)
        {
            await _caixaCabService.AddAsync(caixacab);
        }
        

        // PUT: api/CaixaCab/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CaixaCab caixaCab)
        {
            if (id != caixaCab.IdCaixaCab)
            {
                return BadRequest();
            }

            //_caixaCabService.Entry(caixaCabs).State = EntityState.Modified;

            try
            {
                _caixaCabService.Update(caixaCab);
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
        public async Task<ActionResult<CaixaCab>> PostCaixaCabs(CaixaCab caixaCab)
        {
          
            _caixaCabService.AddAsync(caixaCab);

            return CreatedAtAction("GetCaixaCabs", new { id = caixaCab.IdCaixaCab }, caixaCab);
        }

        // DELETE: api/CaixaCab/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCaixaCaixaCab(int id)
        {
            var caixaCab = await _caixaCabService.FindByIdAsync(id);
            if (caixaCab == null)
            {
                return NotFound();
            }

            _caixaCabService.Remove(caixaCab);
            

            return NoContent();
        }

        //private bool CaixaCabExists(int id)
        //{
        //    //return _caixaCabService.an.caixaCabs.Any(e => e.Id == id);
        //}


    }
}
