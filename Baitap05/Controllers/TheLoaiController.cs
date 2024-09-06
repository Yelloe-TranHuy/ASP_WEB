using Baitap05.Models;
using Microsoft.AspNetCore.Mvc;

namespace Baitap05.Controllers
{
    public class TheLoaiController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Ngay = "Ngày 30";
            ViewBag.Thang = "Tháng 02";
            ViewBag.Nam = "Năm 2030";
            return View();
        }
        public IActionResult Index2()
        {
            var theloai = new TheLoaiViewModel
            {
                Id = 1,
                Name = "Trinh thám"
            };

            return View(theloai);
        }
    }
}
