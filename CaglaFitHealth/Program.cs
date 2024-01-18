using CaglaFitHealth.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSession();


//Register
builder.Services.AddDbContext<ApplicationDbContext>(options =>options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseSession();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    name: "Login",
    pattern: "{controller=Home}/{action=Login}/{id?}");
app.MapControllerRoute(
    name: "Ana Sayfa",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "Üye Yönetimi",
    pattern: "{controller=Member}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "Antrenör Yönetimi",
    pattern: "{controller=Trainer}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "Üyelik Yönetimi",
    pattern: "{controller=Subscription}/{action=Index}/{id?}");

app.Run();
