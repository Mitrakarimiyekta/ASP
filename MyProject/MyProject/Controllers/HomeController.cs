// استفاده از فضای نام 
using Microsoft.AspNetCore.Mvc;
using MyProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace MyProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly GardeshgariDbContext _db;

        //ساختن نمونه از دیتابیسم تکنیک تزریق وابستگی 
        public HomeController(GardeshgariDbContext db)
        {
            //مقداردهی اولیه از دیتابیسم
            _db = db;   

        }

 
        public IActionResult Index()
        {
            //جدول دیتابیسم رو میفرسته بسمت ویو ایندکس
            return View(_db.Pageslocs.ToList());
        }

        public IActionResult About()
        {
            //جدول دیتابیسم رو میفرسته بسمت ویو ایندکس
            return View();
        }
    }
}
