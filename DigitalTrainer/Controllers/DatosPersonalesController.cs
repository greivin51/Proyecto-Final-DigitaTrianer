using Microsoft.AspNetCore.Mvc;
using DigitalTrainer.Models;

namespace DigitalTrainer.Controllers
{
    // Controlador para gestionar los datos personales de usuarios
    public class DatosPersonalesController : Controller
    {
        // Servicio para acceder a la capa de datos
        private Service service;

        // Constructor que inicializa el servicio
        public DatosPersonalesController()
        {
            this.service = new Service(); // Instancia del servicio de acceso a datos
        }

        // GET: DatosPersonales
        // Muestra la lista de todos los registros de datos personales
        public IActionResult Index()
        {
            // Obtiene todos los datos personales y los pasa a la vista
            return View(service.mostrarDatosPersonales());
        }

        // GET: DatosPersonales/Create
        // Muestra el formulario para crear nuevos datos personales
        public IActionResult Create() => View(); // Versión simplificada de return View()

        // POST: DatosPersonales/Create
        // Procesa el formulario de creación
        [HttpPost]
        [ValidateAntiForgeryToken] // Protección contra ataques CSRF
        public IActionResult Create(DatosPersonales datos)
        {
            // Valida el modelo antes de procesar
            if (!ModelState.IsValid)
                return View(datos); // Si no es válido, muestra la vista con errores

            // Si el modelo es válido, agrega los datos
            service.agregarDatosPersonales(datos);

            // Redirige al listado principal
            return RedirectToAction(nameof(Index));
        }

        // GET: DatosPersonales/Edit/5
        // Muestra el formulario de edición
        public IActionResult Edit(int id)
        {
            // Busca los datos existentes por ID
            var datosAnteriores = service.buscarDatosPersonales(id);

            // Muestra la vista de edición con los datos encontrados
            return View(datosAnteriores);
        }

        // POST: DatosPersonales/Edit/5
        // Procesa el formulario de edición
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(DatosPersonales datos)
        {
            // Valida el modelo antes de procesar
            if (!ModelState.IsValid)
                return View(datos); // Si no es válido, muestra la vista con errores

            // Si el modelo es válido, actualiza los datos
            service.actualizarDatosPersonales(datos);

            // Redirige al listado principal
            return RedirectToAction(nameof(Index));
        }

        // GET: DatosPersonales/Delete/5
        // Elimina un registro (no usa vista de confirmación)
        public IActionResult Delete(int id)
        {
            // Busca los datos por ID
            var datos = service.buscarDatosPersonales(id);

            // Si existen, los elimina
            if (datos != null)
                service.eliminarDatosPersonales(datos);

            // Redirige al listado principal
            return RedirectToAction(nameof(Index));
        }
    }
}