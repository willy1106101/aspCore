var builder = WebApplication.CreateBuilder(args);
// 建立MVC 初始化
builder.Services.AddMvc();

var app = builder.Build();

// 使用靜態資料夾
app.UseStaticFiles();

// 建立初始顯示畫面
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
