using Microsoft.AspNetCore.Mvc;
using projectA.Data;

namespace projectA.Controllers
{
    public class SanPhamController : Controller
    {
        public readonly ApplicationDbContext;
        public IActionResult Index()
        {
            return View();
        }
    }
}
