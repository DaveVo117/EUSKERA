using Microsoft.AspNetCore.Mvc;

namespace EUSKERA.AplicacionWeb.Controllers
{
    public class EmpresaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
