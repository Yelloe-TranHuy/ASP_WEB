using Microsoft.AspNetCore.Mvc;

namespace BTVN02.Controllers
{
    public class Tuan02Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.HoTen = "Trần Văn Huy";
            ViewBag.MSSV = " MSSV 1822040665";
            ViewData["Nam"] = DateTime.Now.Year;
            return View();
        }
    }
}