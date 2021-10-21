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
    public class ClienteController : Controller
    {
        private readonly IClienteService _ClienteService;
        public ClienteController(IClienteService clienteService)
        {
            _ClienteService = clienteService;
        }
        [HttpGet]
        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            var clientes = await _ClienteService.ListAsync();

            return clientes;
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Cliente>> GetCliente(int id)
        {
            var cliente = await _ClienteService.FindByIdAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return cliente;
        }
        [HttpGet("GetByUrlSlag/{urlSlag}")]
        public async Task<IEnumerable<Cliente>> GetByUrlSlag(string urlSlag)
        {
            var cliente = await _ClienteService.ListNomes(urlSlag);

            return cliente;
        }

        public async Task AddAsync(Cliente cliente)
        {
            await _ClienteService.AddAsync(cliente);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Cliente cliente)
        {
            if (id != cliente.Codigo)
            {
                return BadRequest();
            }

            try
            {
                _ClienteService.Update(cliente);
            }
            catch (DbUpdateConcurrencyException)
            {

            }

            return NoContent();
        }


        [HttpPost]
        public async Task<ActionResult<Cliente>> PostCliente(Cliente cliente)
        {

            _ClienteService.AddAsync(cliente);

            return CreatedAtAction("Getcliente", new { id = cliente.Codigo }, cliente);
        }

        // DELETE: api/Departamento/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(int id)
        {
            var cliente = await _ClienteService.FindByIdAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }

            _ClienteService.Remove(cliente);


            return NoContent();
        }
    }
}
