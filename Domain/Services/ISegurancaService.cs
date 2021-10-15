using ApiSistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Domain.Services
{
    public interface ISegurancaService
    {
        Task<IEnumerable<Seguranca>> ListAsync();
        Task<IEnumerable<Seguranca>> ListNomes(string name);
        Task<IEnumerable<Seguranca>> ListNomesID(int Id);
        Task AddAsync(Seguranca seguranca);
        Task<Seguranca> FindByIdAsync(int id);
        void Update(Seguranca seguranca);
        void Remove(Seguranca seguranca);
    }
}
