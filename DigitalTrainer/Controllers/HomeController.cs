using System.Diagnostics;
using DigitalTrainer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApp.Pages
{
    // Modelo para la p�gina Razor de Inicio
    public class HomeModel : PageModel
    {
        // Manejador para solicitudes GET a esta p�gina
        public void OnGet()
        {
            // Actualmente vac�o - aqu� se podr�a inicializar datos de la p�gina
        }
    }
}

namespace DigitalTrainer.Controllers
{
    // Controlador MVC para manejar acciones relacionadas al inicio
    public class HomeController : Controller
    {
        // Logger para inyecci�n de dependencias
        private readonly ILogger<HomeController> _logger;

        // Constructor con inyecci�n de dependencias
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger; // Logger inyectado para prop�sitos de registro
        }

        // Acci�n para la p�gina principal
        public IActionResult Index()
        {
            return View(); // Devuelve la vista Index por defecto
        }

        // Acci�n para la p�gina de pol�tica de privacidad
        public IActionResult Privacy()
        {
            return View(); // Devuelve la vista Privacy
        }

        // Acci�n para manejo de errores
        // Desactiva el cach� para asegurar respuestas de error frescas
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Crea un ErrorViewModel con el ID de la solicitud actual
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}