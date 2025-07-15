using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DigitalTrainer.Models;

namespace DigitalTrainer.Controllers
{
    public class MiRutinaController : Controller
    {
        private Service service;

        public MiRutinaController()
        {
            this.service = new Service();
        }
        // GET: MiRutinaController
        public ActionResult Index()
        {
            var miRutina = service.mostrarMiRutina();
            return View(miRutina);
        }

        // GET: MiRutinaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MiRutinaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MiRutinaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MiRutina miRutina)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    this.service.agregarMiRutina(miRutina);
                    return RedirectToAction("Index");
                }
            }
            catch
            { }
            return View();
        }

        // GET: MiRutinaController/Edit/5
        public ActionResult Edit(int id)
        {
            var miRutinaAnterior = service.buscarMiRutina(id);
            return View(miRutinaAnterior);
        }

        // POST: MiRutinaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MiRutina miRutina)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    service.actualizarMiRutina(miRutina);
                    return RedirectToAction("Index");
                }
            }
            catch
            { }
            return View();

        }

        // GET: MiRutinaController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                var miRutinaEliminado = service.buscarMiRutina(id);
                service.eliminarMiRutina(miRutinaEliminado);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return RedirectToAction("Index");
            }


        }

    }
}
