using ApiCro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Domain.Services
{
   public interface IStatusService
    {
        Task<IEnumerable<Status>> ListAsync();
       
        Task<IEnumerable<Status>> ListID(int Id);
    }
}
