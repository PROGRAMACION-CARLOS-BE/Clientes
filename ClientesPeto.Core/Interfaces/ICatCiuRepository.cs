using ClientesPeto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClientesPeto.Core.Interfaces
{
   public interface ICatCiuRepository
    {
        Task<IEnumerable<CatCiu>> GetAll();
        Task<CatCiu> GetById(int id);
        //Task Add(CatCli entity);
        //Task<bool> Update(CatCli entity);
        //Task<bool> Delete(CatCli entity);
        //IEnumerable<CatCliFilter> Previus();
        //IEnumerable<CatCliDocuments> DocumentosByCatCliID(int id);
    }
}
