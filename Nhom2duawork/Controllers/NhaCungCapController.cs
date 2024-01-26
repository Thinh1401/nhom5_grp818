// Controllers/NhaCungCapController.cs

using Microsoft.AspNetCore.Mvc;
using Nhom2duawork.Models;
using System.Collections.Generic;

namespace Nhom2duawork.Controllers
{
    public class NhaCungCapController : Controller
    {
        private readonly NhaCungCapService _nhaCungCapService;

        public NhaCungCapController(NhaCungCapService nhaCungCapService)
        {
            _nhaCungCapService = nhaCungCapService;
        }

        public IActionResult Index()
        {
            List<NhaCungCap> nhaCungCaps = _nhaCungCapService.GetAllNhaCungCaps();
            return View(nhaCungCaps);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(NhaCungCap nhaCungCap)
        {
            _nhaCungCapService.AddNhaCungCap(nhaCungCap);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            NhaCungCap nhaCungCap = _nhaCungCapService.GetNhaCungCapById(id);
            return View(nhaCungCap);
        }

        [HttpPost]
        public IActionResult Edit(NhaCungCap updatedNhaCungCap)
        {
            _nhaCungCapService.UpdateNhaCungCap(updatedNhaCungCap);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            NhaCungCap nhaCungCap = _nhaCungCapService.GetNhaCungCapById(id);
            return View(nhaCungCap);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var existingNhaCungCap = _nhaCungCapService.GetNhaCungCapById(id);

            if (existingNhaCungCap == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _nhaCungCapService.DeleteNhaCungCap(id);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Delete", existingNhaCungCap);
            }
        }
    }
}
