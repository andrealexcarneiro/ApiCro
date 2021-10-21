using ApiSistema.Domain.Services;
using ApiSistema.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class UFController : Controller
    {
        private readonly IUFService _ufService;
        public UFController(IUFService ufService)
        {
            _ufService = ufService;
        }
        [HttpGet]
        public async Task<IEnumerable<UF>> GetAllAsync()
        {
            var ufs  = await _ufService.ListAsync();

            return ufs;
        }

       
        [HttpGet("GetByUrlSlag/{urlSlag}")]
        public async Task<IEnumerable<UF>> GetByUrlSlag(string urlSlag)
        {
            var ufs = await _ufService.ListNomes(urlSlag);

            return ufs;
        }
    }
}
