using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce.Controllers
{
    public class ImageController : Controller
    {
        private List<Item> _items = null;
        public ImageController()
        {
            _items = new Item[] {
            new Item {  title = "NIKE AIR MAX", description = "Very Comfort for sports wear.", price = 4500 },
            new Item {  title = "NIKE AIR MAX", description = "Very Comfort for sports wear.", price = 4500 },
            new Item {  title = "NIKE AIR MAX", description = "Very Comfort for sports wear.", price = 4500 },
            new Item {  title = "NIKE AIR MAX", description = "Very Comfort for sports wear.", price = 4500 },
            new Item {  title = "NIKE AIR MAX", description = "Very Comfort for sports wear.", price = 4500 },
            new Item {  title = "NIKE AIR MAX", description = "Very Comfort for sports wear.", price = 4500 },
            new Item {  title = "NIKE AIR MAX", description = "Very Comfort for sports wear.", price = 4500 },
            new Item {  title = "NIKE AIR MAX", description = "Very Comfort for sports wear.", price = 4500 },
            new Item {  title = "NIKE AIR MAX", description = "Very Comfort for sports wear.", price = 4500 },
            }.ToList();
        }

        // GET: Image
        public ActionResult Index()
        {
            return View();
        }

        // GET: Image/Details/5
        public ActionResult Products()
        {
            return View(_items);
        }


        // POST: Image/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Image/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Image/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Image/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Image/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
