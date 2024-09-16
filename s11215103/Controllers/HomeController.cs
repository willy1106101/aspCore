using Microsoft.AspNetCore.Mvc;

namespace s11215103.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.DataTime = DateTime.Now;
            ViewBag.title = "徐嘉瑋的首頁";
           return View();
        }   
    }
}
