using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DigitalTrainer.Models;

namespace DigitalTrainer.Controllers
{
    public class RutinaController : Controller
    {
        private Service service;

        public RutinaController()
        {
            this.service = new Service();
        }

        // GET: RutinaController
        public ActionResult Index()
        {
            var rutinas = service.mostrarRutinas();
            return View(rutinas);
        }

        // GET: RutinaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RutinaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RutinaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Rutina rutina)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    this.service.agregarRutinas(rutina);
                    return RedirectToAction("Index");
                }
            }
            catch
            { }
            return View();
        }

        // GET: RutinaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RutinaController/Edit/5
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

        // GET: RutinaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RutinaController/Delete/5
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
