using ApiSistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Domain.Services
{
    public interface INfSaidaService
    {
        Task<IEnumerable<NfSaida>> ListAsync();
        Task<IEnumerable<NfSaida>> ListNomes(string name);
        Task<IEnumerable<NfSaida>> ListNomesID(int Id);
        Task AddAsync(NfSaida nfs);
        Task<NfSaida> FindByIdAsync(int id);
        void Update(NfSaida nfs);
        void Remove(NfSaida nfs);
    }
}
