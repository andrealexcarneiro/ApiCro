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
    public class CidadeController : Controller
    {
        private readonly ICidadeService _CidadeService;
        public CidadeController(ICidadeService cidadeService)
        {
            _CidadeService = cidadeService;
        }
        [HttpGet]
        public async Task<IEnumerable<Cidades>> GetAllAsync()
        {
            var cidade = await _CidadeService.ListAsync();

            return cidade;
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Cidades>> GetCidade(int id)
        {
            var cidade = await _CidadeService.FindByIdAsync(id);

            if (cidade == null)
            {
                return NotFound();
            }

            return cidade;
        }
        [HttpGet("GetByUrlSlag/{urlSlag}")]
        public async Task<IEnumerable<Cidades>> GetByUrlSlag(string urlSlag)
        {
            var cidade = await _CidadeService.ListNomes(urlSlag);

            return cidade;
        }

        public async Task AddAsync(Cidades cidade)
        {
            await _CidadeService.AddAsync(cidade);
        }


        


      
    }
}
