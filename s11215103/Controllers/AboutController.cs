using Microsoft.AspNetCore.Mvc;

namespace s11215103.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.DataTime = DateTime.Now;
            ViewBag.title = "徐嘉瑋-首頁";
            return View();
        }
        public IActionResult HTML()
        {
            return View();
        }

        public IActionResult CSS()
        {
            return View();
        }
    }
}
