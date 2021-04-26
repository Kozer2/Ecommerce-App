using App_Ecommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Ecommerce.Controllers
{
    public class AdminController : Controller
    {
        // GET: AdminsController
        public ActionResult Index()
        {

            var admin = new[]
            {
                new Admin
                {
                    Id = 1,
                    FirstName = "Ben",
                    LastName = "Hemann",
                    UserName = "BHemann",
                }
            };
            return View(admin);
        }

        // GET: AdminsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminsController/Create
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

        // GET: AdminsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminsController/Edit/5
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

        // GET: AdminsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminsController/Delete/5
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
