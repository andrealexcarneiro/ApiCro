using ApiCro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Persistence.Repositories
{
    public interface ISegurancaItensRepository
    {
        Task<IEnumerable<SegurancaItens>> ListAsync();
        Task<IEnumerable<SegurancaItens>> ListNomes(string name);
        Task<IEnumerable<SegurancaItens>> ListNomesID(int Id);
        Task AddAsync(SegurancaItens segurancaItens);
        Task<SegurancaItens> FindByIdAsync(int id);
        void Update(SegurancaItens segurancaItens);
        void Remove(SegurancaItens segurancaItens);
        Task<IEnumerable<SegurancaItens>> ListID(int Id, int IdUsu);
    }
}
