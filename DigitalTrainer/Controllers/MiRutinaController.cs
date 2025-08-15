using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DigitalTrainer.Models;

namespace DigitalTrainer.Controllers
{
    // Controlador para gestionar las rutinas personalizadas de entrenamiento
    public class MiRutinaController : Controller
    {
        // Servicio para acceder a la capa de datos
        private Service service;

        // Constructor que inicializa el servicio
        public MiRutinaController()
        {
            this.service = new Service();
        }

        // GET: MiRutinaController
        // Muestra la lista de todas las rutinas personalizadas
        public ActionResult Index()
        {
            var miRutina = service.mostrarMiRutina(); // Obtiene todas las rutinas
            return View(miRutina); // Pasa la lista a la vista
        }

        // GET: MiRutinaController/Create
        // Muestra el formulario para crear nueva rutina
        public ActionResult Create()
        {
            return View();
        }

        // POST: MiRutinaController/Create
        // Procesa el formulario de creación
        [HttpPost]
        [ValidateAntiForgeryToken] // Protección contra ataques CSRF
        public ActionResult Create(MiRutina miRutina)
        {
            try
            {
                if (ModelState.IsValid) // Valida los datos del modelo
                {
                    this.service.agregarMiRutina(miRutina); // Agrega la nueva rutina
                    return RedirectToAction("Index"); // Redirige al listado
                }
            }
            catch
            {
                // TODO: Registrar el error
            }
            return View(); // Si hay error, muestra la vista nuevamente
        }

        // GET: MiRutinaController/Edit/5
        // Muestra el formulario de edición
        public ActionResult Edit(int id)
        {
            var miRutinaAnterior = service.buscarMiRutina(id); // Busca la rutina por ID
            return View(miRutinaAnterior); // Muestra la vista con los datos
        }

        // POST: MiRutinaController/Edit/5
        // Procesa el formulario de edición
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MiRutina miRutina)
        {
            try
            {
                if (ModelState.IsValid) // Valida los datos del modelo
                {
                    service.actualizarMiRutina(miRutina); // Actualiza la rutina
                    return RedirectToAction("Index"); // Redirige al listado
                }
            }
            catch
            {
                // TODO: Registrar el error
            }
            return View(); // Si hay error, muestra la vista nuevamente
        }

        // GET: MiRutinaController/Delete/5
        // Elimina una rutina (sin vista de confirmación)
        public ActionResult Delete(int id)
        {
            try
            {
                var miRutinaEliminado = service.buscarMiRutina(id); // Busca la rutina
                service.eliminarMiRutina(miRutinaEliminado); // Elimina la rutina
                return RedirectToAction("Index"); // Redirige al listado
            }
            catch (Exception)
            {
                // TODO: Registrar el error
                return RedirectToAction("Index");
            }
        }
    }
}