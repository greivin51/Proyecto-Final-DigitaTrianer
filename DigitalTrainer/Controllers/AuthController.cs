using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DigitalTrainer.Models;
using System.Linq;

namespace DigitalTrainer.Controllers
{
    // Controlador para manejar autenticación y registro de usuarios
    public class AuthController : Controller
    {
        // Instancia del servicio para acceder a la base de datos
        private Service service = new Service();

        // GET: AuthController
        // Vista principal del controlador (no implementada)
        public ActionResult Index()
        {
            return View();
        }

        // GET: AuthController/Details/5
        // Vista de detalles (no implementada)
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AuthController/Create
        // Vista para creación (no implementada)
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthController/Create
        // Método para procesar creación (no implementado)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthController/Edit/5
        // Vista para edición (no implementada)
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AuthController/Edit/5
        // Método para procesar edición (no implementado)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthController/Delete/5
        // Vista para eliminación (no implementada)
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AuthController/Delete/5
        // Método para procesar eliminación (no implementado)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: /Auth/Login
        // Muestra la vista de login
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Auth/Login
        // Procesa el formulario de login
        [HttpPost]
        public IActionResult Login(string correoElectronico, string password)
        {
            // Busca usuario por email y contraseña
            var usuario = service.datosPersonales.FirstOrDefault(
                u => u.CorreoElectronico == correoElectronico &&
                u.Password == password);

            if (usuario != null)
            {
                // Autenticación básica usando sesión
                HttpContext.Session.SetString("Usuario", usuario.Nombre);
                return RedirectToAction("Index", "Home");
            }

            // Si falla, muestra error
            ViewBag.Error = "Correo o contraseña incorrectos";
            return View();
        }

        // POST: /Auth/Register
        // Procesa el registro de nuevos usuarios
        [HttpPost]
        public IActionResult Register(DatosPersonales datos)
        {
            // Validación: Solo permite un usuario registrado
            if (service.datosPersonales.Any())
            {
                ModelState.AddModelError("", "Ya existe un usuario registrado.");
                return View("Login");
            }

            // Si el modelo es válido, registra al usuario
            if (ModelState.IsValid)
            {
                service.agregarDatosPersonales(datos);
                HttpContext.Session.SetString("Usuario", datos.Nombre);
                return RedirectToAction("Index", "Home");
            }

            return View("Login");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout()
        {
            // Limpiar la sesión
            HttpContext.Session.Clear();

            // Opcional: Si estás usando autenticación basada en cookies
            // await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Login", "Auth");
        }
    }
}