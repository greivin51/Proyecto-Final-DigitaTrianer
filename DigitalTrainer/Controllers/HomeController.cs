using System.Diagnostics;
using DigitalTrainer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApp.Pages
{
    // Modelo para la página Razor de Inicio
    public class HomeModel : PageModel
    {
        // Manejador para solicitudes GET a esta página
        public void OnGet()
        {
            // Actualmente vacío - aquí se podría inicializar datos de la página
        }
    }
}

namespace DigitalTrainer.Controllers
{
    // Controlador MVC para manejar acciones relacionadas al inicio
    public class HomeController : Controller
    {
        // Logger para inyección de dependencias
        private readonly ILogger<HomeController> _logger;

        // Constructor con inyección de dependencias
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger; // Logger inyectado para propósitos de registro
        }

        // Acción para la página principal
        public IActionResult Index()
        {
            return View(); // Devuelve la vista Index por defecto
        }

        // Acción para la página de política de privacidad
        public IActionResult Privacy()
        {
            return View(); // Devuelve la vista Privacy
        }

        // Acción para manejo de errores
        // Desactiva el caché para asegurar respuestas de error frescas
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