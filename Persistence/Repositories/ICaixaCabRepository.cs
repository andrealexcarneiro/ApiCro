using ApiCro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Repositories
{
   public interface ICaixaCabRepository
    {
        Task<IEnumerable<CaixaCab>> ListAsync();
        Task<IEnumerable<CaixaCab>> ListNomesID(int id);
        Task AddAsync (CaixaCab caixaCab);
        Task<CaixaCab> FindByIdAsync(int id);
        Task<CaixaCab> FindByNomeAsync(string nome);
        void Update(CaixaCab caixaCab);
        void Remove(CaixaCab caixaCab);
        Task<IEnumerable<CaixaCab>> ListNomes(string name);
    }
}
