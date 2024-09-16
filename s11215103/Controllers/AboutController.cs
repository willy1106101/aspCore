using Microsoft.AspNetCore.Mvc;

namespace s11215103.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.title = "徐嘉瑋-首頁";
            ViewBag.DataTime = DateTime.Now;
            return View();
        }
    }
}
