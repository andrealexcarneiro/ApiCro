using ApiCro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Domain.Services
{
    public interface ICaixaCabService
    {
        Task<IEnumerable<CaixaCab>> ListAsync();
        Task<IEnumerable<CaixaCab>> ListNomes(string name);
        Task<IEnumerable<CaixaCab>> ListNomesID(int Id);
        Task AddAsync(CaixaCab caixaCabs);
        Task<CaixaCab> FindByIdAsync(int id);
        void Update(CaixaCab caixaCab);
        void Remove(CaixaCab caixaCab);
    }
}
