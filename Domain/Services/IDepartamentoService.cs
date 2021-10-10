using ApiCro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Domain.Services
{
    public interface IDepartamentoService
    {
        Task<IEnumerable<Departamentos>> ListAsync();
        Task<IEnumerable<Departamentos>> ListNomes(string name);
        Task<IEnumerable<Departamentos>> ListNomesID(int Id);
        Task AddAsync(Departamentos departamento);
        Task<Departamentos> FindByIdAsync(int id);
        void Update(Departamentos departamento);
        void Remove(Departamentos departamento);

    }
}
