using Microsoft.AspNetCore.Mvc;

using AutoMapper;
using EUSKERA.AplicacionWeb.Models.ViewModels;
using EUSKERA.BLL.Interfaces;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.AspNetCore.Authorization;

namespace EUSKERA.AplicacionWeb.Controllers
{
    //Seguridad de Inicio de Sesion
    [Authorize]

    public class ReporteController : Controller
    {
/*ATRIBUTOS*/
        private readonly IMapper _mapper;
        private readonly IVentaService _ventaService;

        public ReporteController(IMapper mapper, IVentaService ventaService)//Constructor
        {
            _mapper = mapper;
            _ventaService = ventaService;
        }




        /*METODOS*/
        public IActionResult Index()
        {
            return View();
        }




        [HttpGet]
        public  async Task<IActionResult> ReporteVenta(string fechaIni, string fechaFin)
        {
            List<VMReporteVenta> vmLista = _mapper.Map<List<VMReporteVenta>>( await _ventaService.Reporte(fechaIni, fechaFin));

            return StatusCode(StatusCodes.Status200OK, new { data = vmLista });
        }









    }
}
