using ApiSistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Domain.Services
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> ListAsync();
        Task<IEnumerable<Cliente>> ListNomes(string name);
        Task<IEnumerable<Cliente>> ListNomesID(int Id);
        Task AddAsync(Cliente clientes);
        Task<Cliente> FindByIdAsync(int id);
        void Update(Cliente clientes);
        void Remove(Cliente clientes);
    }
}
