// Controllers/KhachHangController.cs
using Microsoft.AspNetCore.Mvc;
using Nhom2duawork.Models;
using System.Collections.Generic;

namespace Nhom2duawork.Controllers
{
    public class KhachHangController : Controller
    {
        private readonly KhachHangService _khachHangService;

        public KhachHangController(KhachHangService khachHangService)
        {
            _khachHangService = khachHangService;
        }

        public IActionResult Index()
        {
            List<KhachHang> khachHangs = _khachHangService.GetAllKhachHangs();
            return View(khachHangs);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(KhachHang khachHang)
        {
            _khachHangService.AddKhachHang(khachHang);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            KhachHang khachHang = _khachHangService.GetKhachHangById(id);
            return View(khachHang);
        }

        [HttpPost]
        public IActionResult Edit(KhachHang updatedKhachHang)
        {
            _khachHangService.UpdateKhachHang(updatedKhachHang);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            KhachHang khachHang = _khachHangService.GetKhachHangById(id);
            return View(khachHang);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var existingKhachHang = _khachHangService.GetKhachHangById(id);

            if (existingKhachHang == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _khachHangService.DeleteKhachHang(id);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Delete", existingKhachHang);
            }
        }

    }
}
