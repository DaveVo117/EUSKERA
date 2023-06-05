using Microsoft.AspNetCore.Mvc;

namespace EUSKERA.AplicacionWeb.Controllers
{
    public class ServicioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
