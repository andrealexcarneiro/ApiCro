﻿using ApiSistema.Models;
using ApiSistema.Repositories;
using ApiSistema.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;


namespace ApiSistema.Controllers
{
  
    [Route("v1/account")]
   
   
        public class HomeController : Controller
        {
            [HttpPost]
            [Route("login")]
            [AllowAnonymous]
            public async Task<ActionResult<dynamic>> Authenticate([FromBody] User model)
            {
               var user = UserRepository.Get("andre", "andre");

                if (user == null)
                    return NotFound(new { message = "Usuário ou senha inválidos" });

                var token = TokenService.GenerateToken(user);
                user.Senha = "";

            return new             {
                //user = user,
                token = token
            };
        }

            [HttpGet]
            [Route("anonymous")]
            [AllowAnonymous]
            public string Anonymous() => "Anônimo";

            [HttpGet]
            [Route("authenticated")]
            [Authorize]
            public string Authenticated() => String.Format("Autenticado - {0}", User.Identity.Name);

            [HttpGet]
            [Route("employee")]
            [Authorize(Roles = "employee,manager")]
            public string Employee() => "Funcionário";

            [HttpGet]
            [Route("manager")]
            [Authorize(Roles = "manager")]
            public string Manager() => 
            "Gerente";

        }
    }
