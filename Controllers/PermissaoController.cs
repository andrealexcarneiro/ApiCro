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
    public class PermissaoController : Controller
    {
        private readonly IPermissoesService _permissaoService;
        public PermissaoController(IPermissoesService permissaoService)
        {
            _permissaoService = permissaoService;
        }

        [HttpGet]
        public async Task<IEnumerable<Permissoes>> GetAllAsync()
        {
            var permissao = await _permissaoService.ListAsync();

            return permissao;
        }
        //GET: api/CaixaCab/5
        [HttpGet("{id}")]

        public async Task<ActionResult<Permissoes>> GetPermissao(int id)
        {
            var permissao = await _permissaoService.FindByIdAsync(id);

            if (permissao == null)
            {
                return NotFound();
            }

            return permissao;
        }
        [HttpGet("GetByUrlSlag/{urlSlag}")]
        public async Task<IEnumerable<Permissoes>> GetByUrlSlag(string urlSlag)
        {
            var permissao = await _permissaoService.ListNomes(urlSlag);

            return permissao;
        }

        public async Task AddAsync(Permissoes permissao)
        {
            await _permissaoService.AddAsync(permissao);
        }


        // PUT: api/CaixaCab/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Permissoes permissao)
        {
            if (id != permissao.ID)
            {
                return BadRequest();
            }

            //_caixaCabService.Entry(caixaCabs).State = EntityState.Modified;

            try
            {
                _permissaoService.Update(permissao);
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
        public async Task<ActionResult<Permissoes>> PostPermissoes(Permissoes permissao)
        {

            _permissaoService.AddAsync(permissao);

            return CreatedAtAction("Getpermissao", new { id = permissao.ID }, permissao);
        }

        // DELETE: api/CaixaCab/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePermissoes(int id)
        {
            var permissao = await _permissaoService.FindByIdAsync(id);
            if (permissao == null)
            {
                return NotFound();
            }

            _permissaoService.Remove(permissao);


            return NoContent();
        }
    }
}
