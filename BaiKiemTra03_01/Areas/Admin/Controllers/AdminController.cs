using Microsoft.AspNetCore.Mvc;
using BaiKiemTra03_01.Data;
using BaiKiemTra03_01.Models;
using AspNetCore;
namespace BaiKiemTra03_01.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AdminController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var nhanvien = _db.NhanVien.ToList();
            ViewBag.NhanVien = nhanvien;
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(NhanVien nhanVien)
        {
            if (ModelState.IsValid)
            {
                // Thêm thông tin vào bảng NhanVien
                _db.NhanVien.Add(nhanVien);
                // Lưu lại
                _db.SaveChanges();
                // Chuyển trang về index
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var nhanVien = _db.NhanVien.Find(id);
            return View(nhanVien);
        }

        [HttpPost]
        public IActionResult Edit(NhanVien theloai)
        {
            if (ModelState.IsValid)
            {
                // Thêm thông tin vào bảng TheLoai
                _db.NhanVien.Update(theloai);
                // Lưu lại
                _db.SaveChanges();
                // Chuyển trang về index
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var theloai = _db.NhanVien.Find(id);
            return View(theloai);
        }

        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var theloai = _db.NhanVien.Find(id);
            if (theloai == null)
            {
                return NotFound();
            }
            _db.NhanVien.Remove(theloai);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Detail(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var theloai = _db.NhanVien.Find(id);
            return View(theloai);
        }
    }
}
