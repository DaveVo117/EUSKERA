using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EUSKERA.Entity;

namespace EUSKERA.DAL.Interfaces
{
    public interface IVentaRepository:IGenericRepository<Venta>
    {
        Task<Venta> Registrar(Venta entidad);
        Task<List<DetalleVenta>> Reporte(DateTime FechaIni,DateTime FechaFin);

    }
}
