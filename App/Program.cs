using App.Models.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Registers the MVC framework's controllers and view components.
builder.Services.AddControllersWithViews();

// This is the startup file for the application
// the constr is the connection string
// connection string works to connect the application with the database connection we use mysql in this app

// Retrieves the connection string value associated with the key "constr". This connection string will be used to connect to the database.
// provides all the critical information needed to establish a connection
//connection strings are typically stored in the (appsettings.json) 
var constr = builder.Configuration.GetConnectionString("constr");   

// this is the mysql connection to the asp.net core mvc application
// AppDbContext class in ASP.NET Core serves as the bridge between the application and the database.
// It is a derived class from DbContext provided by Entity Framework Core (ORM)
// The AppDbContext class is used to configure the database connection and settings.
builder.Services.AddDbContext<AppDbContext>(op=> 
                  op.UseMySql(constr,ServerVersion.AutoDetect(constr)));

/*
Set up the web application and register essential services.
Enable the use of MVC controllers and views for handling HTTP requests and responses.
Retrieve the database connection string from the application's configuration.
Register the AppDbContext class with dependency injection, configured to use MySQL as the database provider and automatically detect the server version.
*/
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
