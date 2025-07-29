using DigitalTrainer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DigitalTrainer.Controllers
{
    public class BatidosController : Controller
    {
        private Service service;

        public BatidosController()
        {
            this.service = new Service();
        }
        // GET: BatidosController
        public ActionResult Index()
        {
            var Batidos = service.mostrarBatidos();
            return View(Batidos);
        }

        // GET: BatidosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BatidosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BatidosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Batidos batidos)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    this.service.agregarBatidos(batidos);
                    return RedirectToAction("Index");
                }
            }
            catch
            { }
            return View();
        }

        // GET: BatidosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BatidosController/Edit/5
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
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BatidosController/Delete/5
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
