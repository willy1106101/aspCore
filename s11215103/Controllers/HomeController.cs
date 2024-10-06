using Microsoft.AspNetCore.Mvc;
using s11215103.Models;

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
        public IActionResult PeopleList()
        {
            IList<People> pList =
            [
                new People { 帳號 = "徐嘉瑋", 性別 = "男", 身高 = 175, 體重 = 50.5f },
                new People { 帳號 = "ysp", 性別 = "男", 身高 = 165, 體重 = 70.5f },
                new People { 帳號 = "mary", 性別 = "女", 身高 = 165, 體重 = 70.5f },
                new People { 帳號 = "peter", 性別 = "男", 身高 = 190, 體重 = 65.5f },
                new People { 帳號 = "jeny", 性別 = "女", 身高 = 155, 體重 = 40.5f },      
            ];
            foreach (var p in pList)
            {
                p.計算標準體重();
                p.計算BMI();
            }
            return View(pList);
        }

        public IActionResult Bootstrap() {

            IList<People> pList =
            [
                new People { 帳號 = "徐嘉瑋", 性別 = "男", 身高 = 175, 體重 = 50.5f },
                new People { 帳號 = "ysp", 性別 = "男", 身高 = 165, 體重 = 70.5f },
                new People { 帳號 = "peter", 性別 = "女", 身高 = 165, 體重 = 70.5f },
                new People { 帳號 = "mary", 性別 = "男", 身高 = 190, 體重 = 65.5f },
                new People { 帳號 = "jeny", 性別 = "女", 身高 = 155, 體重 = 40.5f },
            ];
            foreach (var p in pList)
            {
                p.計算標準體重();
                p.計算BMI();
            }
            return View(pList);
        }

        public IActionResult FoodList()
        {

            IList<Food> pList =
            [
                new Food { 編號 = "F01", 名稱 = "屯經拉麵", 單價 = 280 },
                new Food { 編號 = "F02", 名稱 = "金三角生角片", 單價 = 540 },
                new Food { 編號 = "F03", 名稱 = "幽靈肉粽", 單價 = 30 },
            ];
            return View(pList);
        }

        public IActionResult Layout()
        {
            return View();
        }
    }
}