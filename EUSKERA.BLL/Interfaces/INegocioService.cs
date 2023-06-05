using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EUSKERA.Entity;

namespace EUSKERA.BLL.Interfaces
{
    public interface INegocioService
    {

        Task<Negocio> Obtener();

        Task<List<Negocio>> Lista();

        Task<Negocio> GuardarCambios(Negocio entidad, Stream Logo = null ,string NombreLogo="");
        


    }
}
