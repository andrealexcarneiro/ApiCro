using ApiSistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Persistence.Repositories
{
    public interface ICidadeRepository
    {
        Task<IEnumerable<Cidades>> ListAsync();
        Task<IEnumerable<Cidades>> ListNomes(string name);
        Task<IEnumerable<Cidades>> ListNomesID(int Id);
        Task AddAsync(Cidades cidade);
        Task<Cidades> FindByIdAsync(int id);
        void Update(Cidades cidade);
        void Remove(Cidades cidade);
    }
}
