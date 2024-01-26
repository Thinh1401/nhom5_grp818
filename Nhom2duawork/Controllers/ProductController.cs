// Controllers/ProductController.cs

using Microsoft.AspNetCore.Mvc;
using Nhom2duawork.Models;
using System.Collections.Generic;

namespace Nhom2duawork.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            List<Product> products = _productService.GetAllProducts();
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _productService.AddProduct(product);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Product product = _productService.GetProductById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product updatedProduct)
        {
            _productService.UpdateProduct(updatedProduct);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Product product = _productService.GetProductById(id);
            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var existingProduct = _productService.GetProductById(id);

            if (existingProduct == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _productService.DeleteProduct(id);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Delete", existingProduct);
            }
        }
    }
}
