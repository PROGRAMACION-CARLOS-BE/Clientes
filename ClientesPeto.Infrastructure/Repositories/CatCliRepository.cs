using ClientesPeto.Core.Entities;
using ClientesPeto.Core.Filters;
using ClientesPeto.Core.Interfaces;
using ClientesPeto.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesPeto.Infrastructure.Repositories
{
    public class CatCliRepository : ICatCliRepository
    {
        private readonly EmpPetoContext _context;

        public CatCliRepository(EmpPetoContext context)
        {
            this._context = context;
        }

        public IEnumerable<CatCliDocuments> DocumentosByCatCliID(int id)
        {
            var cve = _context.CatCli.Where(entity => entity.CVECLI == id);
            

            var result = (from e in cve
                          select new CatCliDocuments
                          {
                              CVECLI = e.CVECLI,
                              ARCHIVO1 = e.ARCHIVO1,
                              ARCHIVO1NOM = e.ARCHIVO1NOM
                          }).OrderBy(x => x.CVECLI);
            return result;
        }

        //public object GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        public IEnumerable<CatCliFilter> GetAll()
        {
            var catcli = _context.CatCli;
            var catenviado = _context.ClientesEnviadosGM;
            var catclifilter = new CatCliFilter();

            var query = from e in catcli
                        where !catenviado.Any(d => d.CveCliente == e.CVECLI)
                        select new CatCliFilter
                        {
                            CVECLI = e.CVECLI,
                            NOMCLI = e.NOMCLI,
                            DIRCLI = e.DIRCLI,
                        };

            return query;
        }

        //public Task<CatCli> GetAll()
        //{
        //    var catcli = _context.CatCli;

        //    var query = from e in catcli
        //                where !ClientesEnviadosGM.Any(d => d.CveCliente == e.CVECLI)
        //                select e;
        //    return query;
        //}

        public async Task<CatCli> GetById(int id)
        {
            return await _context.CatCli.SingleOrDefaultAsync(entity => entity.CVECLI == id)!; //?? new Categorias();
        }

        public object GetByIdCiu(int id)
        {
            //var cve = 
            //var CatCiu = _context.CatCiu;
            //var CatCli = _context.CatCli.Where(entity => entity.CVECLI == idcli);

            DbSet<CatCiu> CatCiu;
            IQueryable<CatCli> CatCli;
            var query = from cli in CatCli = _context.CatCli.Where(entity => entity.CVECLI ==id)
                        join ciu in CatCiu = _context.CatCiu on cli.CIUCLI equals ciu.CveCiu
                        select new
                        {
                            cli.CVECLI,
                            cli.NOMCLI,
                            cli.DIRCLI,
                            cli.COLCLI,
                            cli.CPCLI,
                            cli.CIUCLI,
                            ciu.DesCiu,
                            cli.RFCCLI,
                            cli.CURPCLI,
                            cli.EMAILCLI,
                            cli.TEL1CLI,
                            cli.IDENTCLI,
                            cli.GRUCLI,
                            cli.CVEOCU,
                            cli.CVENAC,
                            cli.CVEEDUCIV,
                            cli.TEL2CLI,
                            cli.CVEMED,
                            cli.FECALT,
                            cli.FecNac,
                            cli.Sexo,
                            cli.ARCHIVO1,
                            cli.ARCHIVO1NOM,
                            
                        };
            
            return query;

        }


        public IEnumerable<CatCliFilter> Previus()
        {
            var clientes = _context.CatCli;
            //var clientesgema = _context.ClientesEnviadosGM;

            //var result = (from e in clientes
            //              select e).Except(clientesgema);


            var result = (from e in clientes
                          select new CatCliFilter
                          {
                              CVECLI = e.CVECLI,
                              NOMCLI = e.NOMCLI,
                              DIRCLI = e.DIRCLI
                          });
            return result;
        }

    }
}
