using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using EUSKERA.DAL.DBContext;
using EUSKERA.DAL.Implementacion;
using EUSKERA.DAL.Interfaces;
using EUSKERA.BLL.Implementacion;
using EUSKERA.BLL.Interfaces;


namespace EUSKERA.IOC
{
    public static class Dependencia
    {
        public static void InyectarDependencia(this IServiceCollection Services,IConfiguration Configuration)
        {
            Services.AddDbContext<EUSKERA_DBContext>(optionsAction =>
            {
                optionsAction.UseSqlServer(Configuration.GetConnectionString("CadenaSQL"));
            });

            //contenedor genérico para cualquier entidad 
            Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            
            //contenedor para VentaRepository
            Services.AddScoped<IVentaRepository, VentaRepository>();

            //Servicio de envío de correo
            Services.AddScoped<ICorreoService, CorreoService>();
            //Servicio de almacenamiento multimedia
            Services.AddScoped<IFireBaseService, FireBaseService>();
            //Servicio de Utilidades
            Services.AddScoped<IUtilidadesService, UtilidadesService>();
            //Servicio de Roles
            Services.AddScoped<IRolService, RolService>();
            //Servicio de registro y modificación de Usuario
            Services.AddScoped<IUsuarioService, UsuarioService>();
            //Servicio de registro y modificación de Neogicio
            Services.AddScoped<INegocioService, NegocioService>();
            //Servicio de registro y modificación de Categoría
            Services.AddScoped<ICategoriaService, CategoriaService>();
            //Servicio de registro de Producto
            Services.AddScoped<IProductoService, ProductoService>();
            //Servicio de registro de TipoDocumento
            Services.AddScoped<ITipoDocumentoVentaService, TipoDocumentoVentaService>();
            //Servicio de registro de Ventas
            Services.AddScoped<IVentaService, VentaService>();
            //Servicio de DashBoard
            Services.AddScoped<IDashBoardService, DashBoardService>();
        }
   
    }
}
