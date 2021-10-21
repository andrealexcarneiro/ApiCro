using ApiSistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Persistence.Repositories
{
    public interface IUFRepository
    {
        Task<IEnumerable<UF>> ListAsync();
        Task<IEnumerable<UF>> ListNomes(string name);
    }
}
