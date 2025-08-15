using DigitalTrainer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DigitalTrainer.Controllers
{
    // Controlador para gestionar operaciones CRUD de batidos
    public class BatidosController : Controller
    {
        // Servicio para acceder a la capa de datos
        private Service service;

        // Constructor que inicializa el servicio
        public BatidosController()
        {
            this.service = new Service(); // Instancia del servicio de acceso a datos
        }

        // GET: BatidosController
        // Muestra la lista de todos los batidos
        public ActionResult Index()
        {
            var Batidos = service.mostrarBatidos(); // Obtiene todos los batidos
            return View(Batidos); // Pasa la lista a la vista
        }

        // GET: BatidosController/Details/5
        // Muestra detalles de un batido específico (no implementado)
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BatidosController/Create
        // Muestra el formulario para crear nuevo batido
        public ActionResult Create()
        {
            return View(); // Retorna vista de creación
        }

        // POST: BatidosController/Create
        // Procesa el formulario de creación
        [HttpPost]
        [ValidateAntiForgeryToken] // Protección contra CSRF
        public ActionResult Create(Batidos batidos)
        {
            try
            {
                if (ModelState.IsValid) // Valida el modelo
                {
                    this.service.agregarBatidos(batidos); // Agrega el nuevo batido
                    return RedirectToAction("Index"); // Redirige al listado
                }
            }
            catch
            {
                // Captura errores (debería registrar el error)
            }
            return View(); // Si hay error, muestra la vista nuevamente
        }

        // GET: BatidosController/Edit/5
        // Muestra formulario de edición (no implementado)
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BatidosController/Edit/5
        // Procesa el formulario de edición (no implementado)
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

        // GET: BatidosController/Delete/5
        // Muestra confirmación de eliminación (no implementado)
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BatidosController/Delete/5
        // Procesa la eliminación (no implementado)
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
    }
}