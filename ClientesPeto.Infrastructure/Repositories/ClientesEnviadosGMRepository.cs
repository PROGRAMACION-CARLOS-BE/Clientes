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
    public class ClientesEnviadosGMRepository : IClientesEnviadosGMRepository
    {
        private readonly EmpPetoContext _context;

        public ClientesEnviadosGMRepository(EmpPetoContext context)
        {
            this._context = context;
        }


        public async Task Add(ClientesEnviadosGM entity)
        {
            _context.ClientesEnviadosGM.Add(entity);
            entity.FechaEnviado = System.DateTime.Now;
            await _context.SaveChangesAsync();
        }

        public Task<bool> Baja(ClientesEnviadosGM entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ClientesEnviadosGM>> GetAll()
        {
            return await _context.ClientesEnviadosGM.ToListAsync();
        }

        public Task<ClientesEnviadosGM> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(ClientesEnviadosGM entity)
        {
            throw new NotImplementedException();
        }
    }
}
