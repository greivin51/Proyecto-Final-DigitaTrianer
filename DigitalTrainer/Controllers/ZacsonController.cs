﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DigitalTrainer.Controllers
{
    public class ZacsonController : Controller
    {
        // GET: ZacsonController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ZacsonController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ZacsonController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ZacsonController/Create
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

        // GET: ZacsonController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ZacsonController/Edit/5
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

        // GET: ZacsonController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ZacsonController/Delete/5
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
