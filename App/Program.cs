using App.Models.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// This is the startup file for the application
// the constr is the connection string
// connection string works to connect the application with the database connection we use mysql in this app

var constr = builder.Configuration.GetConnectionString("constr");

// this is the mysql connection to the asp.net core mvc application
// AppDbContext class in ASP.NET Core serves as the bridge between the application and the database.
// It is a derived class from DbContext provided by Entity Framework Core (ORM)
// The AppDbContext class is used to configure the database connection and settings.
builder.Services.AddDbContext<AppDbContext>(op=> 
                  op.UseMySql(constr,ServerVersion.AutoDetect(constr)));

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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
