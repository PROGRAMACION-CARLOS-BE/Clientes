using ClientesPeto.Core;
using ClientesPeto.Core.DTOs.AliadoDTOs;
using ClientesPeto.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClientesPeto.Infrastructure.Repositories
{
   public class LoginRepository
    {
        private readonly InventaDINContext _context;

        public LoginRepository(InventaDINContext context)
        {
            this._context = context;
        }

        public async Task<Aliado> GetAdmin(AliadoDto entity)
        {
            return await _context.Aliado.SingleOrDefaultAsync(x => x.Usuario == entity.Usuario && x.Nss == entity.Nss);
        }
    }
}
