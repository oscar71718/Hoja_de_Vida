using Microsoft.AspNetCore.Mvc;

namespace prjHojaDeVida.Controllers
{
    public class HomeController : Controller
    {

        //Carga la vista principal
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        //Carga la vista de inicio una vez se está en otra página
        [Route("Inicio.html")]
        public IActionResult Inicio()
        {
            return View("Views/Home/Index.cshtml");
        }
    }
}
