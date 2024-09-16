var builder = WebApplication.CreateBuilder(args);
// �إ�MVC ��l��
builder.Services.AddMvc();

var app = builder.Build();

// �ϥ��R�A��Ƨ�
app.UseStaticFiles();

// �إߪ�l��ܵe��
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
