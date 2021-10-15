using ApiSistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Domain.Services
{
    public interface ICnaeService
    {
        Task<IEnumerable<Cnae>> ListAsync();
        Task<IEnumerable<Cnae>> ListNomes(string name);
        Task<IEnumerable<Cnae>> ListNomesID(int Id);
        Task AddAsync(Cnae canes);
        Task<Cnae> FindByIdAsync(int id);
        void Update(Cnae cnaes);
        void Remove(Cnae cnaes);
    }
}
