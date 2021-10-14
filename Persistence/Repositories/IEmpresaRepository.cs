using ApiSistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Persistence.Repositories
{
    public interface IEmpresaRepository
    {
        Task<IEnumerable<Empresa>> ListAsync();
        Task<IEnumerable<Empresa>> ListNomes(string name);
        Task<IEnumerable<Empresa>> ListNomesID(int Id);
        Task AddAsync(Empresa empresa);
        Task<Empresa> FindByIdAsync(int id);
        void Update(Empresa empresa);
        void Remove(Empresa empresa);

    }
}
