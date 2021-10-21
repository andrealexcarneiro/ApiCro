using ApiSistema.Models;
using ApiSistema.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Domain.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Task AddAsync(Cliente clientes)
        {
            return _clienteRepository.AddAsync(clientes);
        }

        public async Task<Cliente> FindByIdAsync(int id)
        {
            return await _clienteRepository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<Cliente>> ListAsync()
        {
            return await _clienteRepository.ListAsync();
        }

        public async Task<IEnumerable<Cliente>> ListNomes(string name)
        {
            return await _clienteRepository.ListNomes(name);
        }

        public async Task<IEnumerable<Cliente>> ListNomesID(int Id)
        {
            return await _clienteRepository.ListNomesID(Id);
        }

        public void Remove(Cliente clientes)
        {
            _clienteRepository.Remove(clientes);
        }

        public void Update(Cliente clientes)
        {
            _clienteRepository.Update(clientes);
        }
    }
}
