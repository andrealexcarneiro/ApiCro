using ApiCro.Models;
using ApiCro.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Persistence.Repositories
{
    public class StatusRepository : BaseRepository, IStatusRepository
    {
        public StatusRepository(AppDbContext context) : base(context)
        { }

        public async Task<IEnumerable<Status>> ListAsync()
        {
            return await _context.Statuses.ToListAsync();
        }

        public async Task<IEnumerable<Status>> ListID(int Id)
        {
            using (var contexto = new AppDbContext())
            {

                var ListarID = (from Status in contexto.Statuses
                                where Status.Id == Id

                                select new Status

                                {
                                    Id = Status.Id,
                                    StatusCaixa = Status.StatusCaixa

                                }).ToList();

                return (IEnumerable<Status>)ListarID;
            }
        }

    }
}
