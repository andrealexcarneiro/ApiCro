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
    public class ConfiguracoesController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
