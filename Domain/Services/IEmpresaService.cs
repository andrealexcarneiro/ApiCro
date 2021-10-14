using ApiSistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Domain.Services
{
    public interface IEmpresaService
    {
        Task<IEnumerable<Empresa>> ListAsync();
        Task<IEnumerable<Empresa>> ListNomes(string name);
        Task<IEnumerable<Empresa>> ListNomesID(int Id);
        Task AddAsync(Empresa empresas);
        Task<Empresa> FindByIdAsync(int id);
        void Update(Empresa empresas);
        void Remove(Empresa empresas);
    }
}
