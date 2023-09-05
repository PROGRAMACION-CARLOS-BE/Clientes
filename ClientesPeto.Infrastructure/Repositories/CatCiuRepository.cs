using ClientesPeto.Core.Entities;
using ClientesPeto.Core.Interfaces;
using ClientesPeto.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClientesPeto.Infrastructure.Repositories
{
    public class CatCiuRepository : ICatCiuRepository
    {
        private readonly EmpPetoContext _context;

        public CatCiuRepository(EmpPetoContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<CatCiu>> GetAll()
        {
            return await _context.CatCiu.ToListAsync();
        }

        public async Task<CatCiu> GetById(int id)
        {
            return await _context.CatCiu.SingleOrDefaultAsync(entity => entity.CveCiu == id)!;
        }
    }
}
