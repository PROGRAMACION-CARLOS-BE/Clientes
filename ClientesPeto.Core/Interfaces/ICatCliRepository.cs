using ClientesPeto.Core.Entities;
using ClientesPeto.Core.Filters;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace ClientesPeto.Core.Interfaces
{
   public interface ICatCliRepository
    {
        IEnumerable<CatCliFilter> GetAll();
        Task<CatCli> GetById(int id);
        object GetByIdCiu(int id);
        //Task Add(CatCli entity);
        //Task<bool> Update(CatCli entity);
        //Task<bool> Delete(CatCli entity);
        IEnumerable<CatCliFilter> Previus();
        IEnumerable<CatCliDocuments> DocumentosByCatCliID(int id);
        
    }
}
