using ClientesPeto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClientesPeto.Core.Interfaces
{
    public interface IClientesEnviadosGMRepository
    {
        Task<IEnumerable<ClientesEnviadosGM>> GetAll();
        Task<ClientesEnviadosGM> GetById(int id);
        Task Add(ClientesEnviadosGM entity);
        Task<bool> Update(ClientesEnviadosGM entity);

        // IEnumerable<Productos> GetProductoFilter(ProductoFilters filters);
        Task<bool> Baja(ClientesEnviadosGM entity);

    }
}
