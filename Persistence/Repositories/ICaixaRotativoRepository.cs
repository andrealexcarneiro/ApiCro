using ApiCro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Persistence.Repositories
{
    public interface ICaixaRotativoRepository
    {
        Task<IEnumerable<CaixaRotativo>> ListAsync();
        Task<IEnumerable<CaixaRotativo>> ListNomes(string name);
        Task<IEnumerable<CaixaRotativo>> ListNomesID(int id);
        Task<IEnumerable<CaixaRotativo>> ListID(int Id);
        Task<IEnumerable<CaixaRotativo>> ListSomaID(int Id);

        Task AddAsync(CaixaRotativo caixaRotativo);

        Task<CaixaRotativo> FindByIdAsync(int id);

        void Update(CaixaRotativo caixaRotativo);
        void Remove(CaixaRotativo caixaRotativo);

    }
}
