using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DigitalTrainer.Models;

namespace DigitalTrainer.Controllers
{
    // Controlador para gestionar las operaciones CRUD de rutinas de ejercicio
    public class RutinaController : Controller
    {
        // Instancia del servicio para acceder a la capa de datos
        private Service service;

        // Constructor que inicializa el servicio
        public RutinaController()
        {
            this.service = new Service();
        }

        // GET: RutinaController
        // Muestra la lista completa de todas las rutinas disponibles
        public ActionResult Index()
        {
            // Obtiene todas las rutinas del servicio
            var rutinas = service.mostrarRutinas();
            // Devuelve la vista con la lista de rutinas
            return View(rutinas);
        }

        // GET: RutinaController/Details/5
        // Muestra los detalles de una rutina específica (no implementado)
        public ActionResult Details(int id)
        {
            // Vista de detalles (pendiente de implementación)
            return View();
        }

        // GET: RutinaController/Create
        // Muestra el formulario para crear una nueva rutina
        public ActionResult Create()
        {
            // Devuelve la vista con el formulario vacío
            return View();
        }

        // POST: RutinaController/Create
        // Procesa el envío del formulario de creación
        [HttpPost] // Atributo que indica que responde a solicitudes POST
        [ValidateAntiForgeryToken] // Protección contra ataques CSRF
        public ActionResult Create(Rutina rutina)
        {
            try
            {
                // Verifica si el modelo recibido es válido
                if (ModelState.IsValid)
                {
                    // Agrega la nueva rutina a través del servicio
                    this.service.agregarRutinas(rutina);
                    // Redirige al listado principal después de crear
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                // Captura cualquier excepción (pendiente de manejo específico)
            }
            // Si hay error, vuelve a mostrar el formulario
            return View();
        }

        // GET: RutinaController/Edit/5
        // Muestra el formulario para editar una rutina (no implementado)
        public ActionResult Edit(int id)
        {
            // Vista de edición (pendiente de implementación)
            return View();
        }

        // POST: RutinaController/Edit/5
        // Procesa el envío del formulario de edición
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // Redirige al listado principal después de editar
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                // Si hay error, vuelve a la vista de edición
                return View();
            }
        }

        // GET: RutinaController/Delete/5
        // Muestra la confirmación para eliminar una rutina (no implementado)
        public ActionResult Delete(int id)
        {
            // Vista de confirmación de eliminación (pendiente de implementación)
            return View();
        }

        // POST: RutinaController/Delete/5
        // Procesa la eliminación de una rutina
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // Redirige al listado principal después de eliminar
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                // Si hay error, vuelve a la vista de confirmación
                return View();
            }
        }
    }
}