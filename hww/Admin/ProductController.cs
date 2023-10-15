using hww.DataBase.DomainModels;
using hww.DataBase;
using Microsoft.AspNetCore.Mvc;
using hww.ViewModels;
using System;
using System.Linq;

namespace hww.Admin
{
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult Products()
        {
            return View(DbContext._products);
        }

        [HttpGet]
        public IActionResult ProductAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitProduct(Product product)
        {
            DbContext._products.Add(product);

            return RedirectToAction("Products");
        }

        [HttpGet]
        public IActionResult ProductEdit(int id)
        {
            var product = DbContext._products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }


        [HttpPost]
        public IActionResult EditSubmitProduct(ProductUpdateViewModel model)
        {
            var product = DbContext._products.FirstOrDefault(p => p.Id == model.Id);
            if (product == null)
            {
                return NotFound();
            }

            product.Description = model.Description;
            product.Color = model.Color;
            product.Size = model.Size;
            product.Price = model.Price;
            product.UpdatedAt = DateTime.Now;

            return RedirectToAction("Products");
        }

        [HttpGet]
        public IActionResult DeleteProduct(int id)
        {
            var product = DbContext._products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            DbContext._products.Remove(product);

            return RedirectToAction("Products");
        }
    }
}