using ApiCro.Domain.Services;
using ApiCro.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class StatusController : Controller
    {
        private readonly IStatusService _StatusService;
        public StatusController(IStatusService statusService)
        {
            _StatusService = statusService;
        }

        [HttpGet]
        public async Task<IEnumerable<Status>> GetAllAsync()
        {
            var cadBI = await _StatusService.ListAsync();

            return cadBI;
        }

        [HttpGet("GetBy/{urlID}")]
        public async Task<IEnumerable<Status>> GetBy(int urlID)
        {
            var cadastroBI = await _StatusService.ListID(urlID);

            return cadastroBI;
        }
    }
}
