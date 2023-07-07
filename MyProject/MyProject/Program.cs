//7 اضافه کردن فریمورک 
using Microsoft.EntityFrameworkCore;


//6 اضافه کردن فضای نام پروژه 
using MyProject.Models;


var builder = WebApplication.CreateBuilder(args);

//1:    برای استفاده از الگوی  معماری mvc 
builder.Services.AddControllersWithViews();

//4 فایل appsetting.json
//5 رجیستر کردن dbcontext
builder.Services.AddDbContext<GardeshgariDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConStr")));


var app = builder.Build();

//2:    برای استفاده از فایلهای استاتیک 
app.UseStaticFiles();


//3:    تعریف حداقل یک پترن 
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home} /{ Action = Index}/{ id?}"
    );

//.MapGet("/", () => "Hello World!");

app.Run();
//8 add-migration mig1_createdb
//9 update-database