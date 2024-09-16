using Microsoft.AspNetCore.Mvc;

namespace s11215103.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.DataTime = DateTime.Now;
            ViewBag.title = "徐嘉瑋-首頁";
            return View();
        }
        public IActionResult HTML()
        {
            // 這裡可以返回 HTML 頁面的視圖
            return View();
        }

        public IActionResult CSS()
        {
            // 這裡可以返回 CSS 頁面的視圖
            return View();
        }
    }
}
