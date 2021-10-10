using ApiCro.Models;
using ApiCro.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Domain.Services
{
    public class StatusService : IStatusService
    {
        private readonly IStatusRepository _StatusRepository;

        public StatusService(IStatusRepository statusRepository)
        {
            _StatusRepository = statusRepository;
        }

        public async Task<IEnumerable<Status>> ListAsync()
        {
            return await _StatusRepository.ListAsync();
        }

        public async Task<IEnumerable<Status>> ListID(int Id)
        {
            return await _StatusRepository.ListID(Id);
        }
    }
}
