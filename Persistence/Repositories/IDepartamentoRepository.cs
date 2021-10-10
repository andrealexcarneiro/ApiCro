using ApiCro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Persistence.Repositories
{
    public interface IDepartamentoRepository
    {
        Task<IEnumerable<Departamentos>> ListAsync();
        Task<IEnumerable<Departamentos>> ListNomesID(int id);
        Task AddAsync(Departamentos caixaCab);
        Task<Departamentos> FindByIdAsync(int id);
        Task<Departamentos> FindByNomeAsync(string nome);
        void Update(Departamentos departamento);
        void Remove(Departamentos departamento);
        Task<IEnumerable<Departamentos>> ListNomes(string name);
    }
}
