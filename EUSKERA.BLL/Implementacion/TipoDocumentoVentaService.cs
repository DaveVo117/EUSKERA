using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EUSKERA.BLL.Interfaces;
using EUSKERA.DAL.Interfaces;
using EUSKERA.Entity;

namespace EUSKERA.BLL.Implementacion
{
    public class TipoDocumentoVentaService : ITipoDocumentoVentaService
    {
        /*ATRIBUTOS*/
        private readonly IGenericRepository<TipoDocumentoVenta> _repositorio;

        public TipoDocumentoVentaService(IGenericRepository<TipoDocumentoVenta> repositorio)//Constructor
        {
            _repositorio = repositorio;
        }




        /*METODOS*/
        public async Task<List<TipoDocumentoVenta>> Lista()
        {
            IQueryable<TipoDocumentoVenta> query = await _repositorio.Consultar();
            return query.ToList();
        }

    }
}
