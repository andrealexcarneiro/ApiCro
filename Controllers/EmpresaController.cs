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
using ApiSistema.Domain.Services;
using ApiSistema.Models;

namespace ApiSistema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class EmpresaController : Controller
    {
        private readonly IEmpresaService _EmpresaService;
        public EmpresaController(IEmpresaService empresaService)
        {
            _EmpresaService = empresaService;
        }
        [HttpGet]
        public async Task<IEnumerable<Empresa>> GetAllAsync()
        {
            var empresas = await _EmpresaService.ListAsync();

            return empresas;
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Empresa>> GetEmpresa(int id)
        {
            var empresa = await _EmpresaService.FindByIdAsync(id);

            if (empresa == null)
            {
                return NotFound();
            }

            return empresa;
        }
        [HttpGet("GetByUrlSlag/{urlSlag}")]
        public async Task<IEnumerable<Empresa>> GetByUrlSlag(string urlSlag)
        {
            var empresa = await _EmpresaService.ListNomes(urlSlag);

            return empresa;
        }

        public async Task AddAsync(Empresa empresa)
        {
            await _EmpresaService.AddAsync(empresa);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Empresa empresa)
        {
            if (id != empresa.Codigo)
            {
                return BadRequest();
            }

            try
            {
                _EmpresaService.Update(empresa);
            }
            catch (DbUpdateConcurrencyException)
            {

            }

            return NoContent();
        }


        [HttpPost]
        public async Task<ActionResult<Empresa>> PostEmpresa(Empresa empresa)
        {

            _EmpresaService.AddAsync(empresa);

            return CreatedAtAction("Getempresa", new { id = empresa.Codigo }, empresa);
        }

        // DELETE: api/Departamento/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmpresa(int id)
        {
            var empresa = await _EmpresaService.FindByIdAsync(id);
            if (empresa == null)
            {
                return NotFound();
            }

            _EmpresaService.Remove(empresa);


            return NoContent();
        }
    }
}
