using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DigitalTrainer.Models;

namespace DigitalTrainer.Controllers
{
    public class DatosPersonalesController : Controller
    {
        private Service service;
        public DatosPersonalesController()
        {
            this.service = new Service();
        }
        // GET: DatosPersonalesController
        public ActionResult Index()
        {
            var datosPersonales = service.mostrarDatosPersonales();
            return View(datosPersonales);
            
        }

        // GET: DatosPersonalesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DatosPersonalesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DatosPersonalesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DatosPersonales datos)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    service.agregarDatosPersonales(datos);
                    return RedirectToAction("Index");
                }
               
            }
            catch
            {
               
            }
            return View();
        }

        // GET: DatosPersonalesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DatosPersonalesController/Edit/5
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

        // GET: DatosPersonalesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DatosPersonalesController/Delete/5
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
