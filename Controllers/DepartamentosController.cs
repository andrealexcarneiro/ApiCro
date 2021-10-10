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
    public class DepartamentosController : ControllerBase
    {
        private readonly IDepartamentoService _departamentoService;
        public DepartamentosController(IDepartamentoService departamentoService)
        {
            _departamentoService = departamentoService;
        }

        [HttpGet]
        public async Task<IEnumerable<Departamentos>> GetAllAsync()
        {
            var departamento = await _departamentoService.ListAsync();

            return departamento;
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Departamentos>> GetDepartamentos(int id)
        {
            var departamento = await _departamentoService.FindByIdAsync(id);

            if (departamento == null)
            {
                return NotFound();
            }

            return departamento;
        }
        [HttpGet("GetByUrlSlag/{urlSlag}")]
        public async Task<IEnumerable<Departamentos>> GetByUrlSlag(string urlSlag)
        {
            var departamento = await _departamentoService.ListNomes(urlSlag);

            return departamento;
        }

        public async Task AddAsync(Departamentos departamento)
        {
            await _departamentoService.AddAsync(departamento);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Departamentos departamento)
        {
            if (id != departamento.ID)
            {
                return BadRequest();
            }

            try
            {
                _departamentoService.Update(departamento);
            }
            catch (DbUpdateConcurrencyException)
            {
                
            }

            return NoContent();
        }

       
        [HttpPost]
        public async Task<ActionResult<Departamentos>> PostDepartamento(Departamentos departamento)
        {

            _departamentoService.AddAsync(departamento);

            return CreatedAtAction("GetDepartamento", new { id = departamento.ID }, departamento);
        }

        // DELETE: api/Departamento/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartamento(int id)
        {
            var departamentos = await _departamentoService.FindByIdAsync(id);
            if (departamentos == null)
            {
                return NotFound();
            }

            _departamentoService.Remove(departamentos);


            return NoContent();
        }

        
    }
}
