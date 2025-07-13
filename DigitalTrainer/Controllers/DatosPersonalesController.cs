using Microsoft.AspNetCore.Mvc;
using DigitalTrainer.Models;

namespace DigitalTrainer.Controllers
{
    public class DatosPersonalesController : Controller
    {
        private  Service service;

        public DatosPersonalesController()
        {
            this.service = new Service();
        }

        // GET
        public IActionResult Index()
        {
            return View(service.mostrarDatosPersonales());
        }

        // GET Create
        public IActionResult Create() => View();

        // POST Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(DatosPersonales datos)
        {
            if (ModelState.IsValid) return View(datos);

           service.agregarDatosPersonales(datos);
            return RedirectToAction(nameof(Index));
        }

        // GET Edit
        public IActionResult Edit(int id)
        {
            var datosAnteriores = service.buscarDatosPersonales(id);
            return View(datosAnteriores);
        }

        // POST Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(DatosPersonales datos)
        {
            if (ModelState.IsValid) return View(datos);

            service.actualizarDatosPersonales(datos);
            return RedirectToAction(nameof(Index));
        }

        // GET Delete
        public IActionResult Delete(int id)
        {
            var datos = service.buscarDatosPersonales(id);
            if (datos != null) service.eliminarDatosPersonales(datos);
            return RedirectToAction(nameof(Index));
        }
    }
}