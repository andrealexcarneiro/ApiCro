using ApiSistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Domain.Services
{
    public interface IUFService
    {
        Task<IEnumerable<UF>> ListAsync();
        Task<IEnumerable<UF>> ListNomes(string name);
       
    }
}
