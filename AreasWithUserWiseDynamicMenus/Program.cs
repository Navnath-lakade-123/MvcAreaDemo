using AreasWithUserWiseDynamicMenus.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddDbContext<DemoDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyCon"));
});

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(10);
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.MapAreaControllerRoute(

    name:"Admin",
    areaName: "Admin",
    pattern:"{area:Exists}/{controller=Dashboard}/{action=Index}/{id?}"
    );
app.MapAreaControllerRoute(

    name: "Accountant",
    areaName: "Accountant",
    pattern: "{area:Exists}/{controller=Dashboard}/{action=Index}/{id?}"
    );

app.MapAreaControllerRoute(

    name: "Teacher",
    areaName: "Teacher",
    pattern: "{area:Exists}/{controller=Dashboard}/{action=Index}/{id?}"
    );

app.MapAreaControllerRoute(

    name: "Student",
    areaName: "Student",
    pattern: "{area:Exists}/{controller=Dashboard}/{action=Index}/{id?}"
    );
app.Run();
