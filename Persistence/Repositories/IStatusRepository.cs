using ApiCro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Persistence.Repositories
{
   public interface IStatusRepository
    {
        Task<IEnumerable<Status>> ListAsync();

        Task<IEnumerable<Status>> ListID(int Id);
    }
}
