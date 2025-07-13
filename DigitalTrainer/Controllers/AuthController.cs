using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DigitalTrainer.Models;
using System.Linq;

namespace DigitalTrainer.Controllers
{
    public class AuthController : Controller
    {
        private Service service = new Service();

        // GET: AuthController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AuthController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AuthController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthController/Create
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
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AuthController/Edit/5
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
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AuthController/Delete/5
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
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Auth/Login
        [HttpPost]
        public IActionResult Login(string correoElectronico, string password)
        {
            var usuario = service.datosPersonales.FirstOrDefault(u => u.CorreoElectronico == correoElectronico && u.Password == password);
            if (usuario != null)
            {
                // Aquí puedes usar autenticación real
                HttpContext.Session.SetString("Usuario", usuario.Nombre);
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Error = "Correo o contraseña incorrectos";
            return View();
        }

        // POST: /Auth/Register
        [HttpPost]
        public IActionResult Register(DatosPersonales datos)
        {
            // Verifica si ya existe un usuario
            if (service.datosPersonales.Any())
            {
                ModelState.AddModelError("", "Ya existe un usuario registrado.");
                return View("Login");
            }

            if (ModelState.IsValid)
            {
                service.agregarDatosPersonales(datos);
                HttpContext.Session.SetString("Usuario", datos.Nombre);
                return RedirectToAction("Index", "Home");
            }
            return View("Login");
        }
    }
}
