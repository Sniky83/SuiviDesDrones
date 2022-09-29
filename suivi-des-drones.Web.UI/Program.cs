using Microsoft.EntityFrameworkCore;
using suivi_des_drones.Core.Application.Repositories;
using suivi_des_drones.Core.Infrastructure.Databases;
using suivi_des_drones.Core.Infrastructure.DataLayers;
using suivi_des_drones.Core.Interfaces.Infrastructures;
using suivi_des_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Infrastructure.Web.Middlewares;
using suivi_des_drones.Core.Infrastructure;
using Microsoft.AspNetCore.Identity;
using suivi_des_drones.Core.Infrastructure.Web.Constraints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages(); //.AddRazorPagesOptions(options => { options.Conventions.AddPageRoute("/CreateDrone", "creation-drone") });

string connectionString = builder.Configuration.GetConnectionString("DroneContext");

builder.Services.AddDbContext<DronesDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

builder.Services.AddDefaultIdentity<AuthenticationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<AuthenticationContext>();

builder.Services.AddDbContext<AuthenticationContext>(options => options.UseSqlServer(connectionString));

//Injections de dépendances
builder.Services.AddScoped<IDroneDataLayer, SqlServerDroneDataLayer>();
builder.Services.AddScoped<IUserDataLayer, SqlServerUserDataLayer>();
builder.Services.AddScoped<IDroneRepository, DroneRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
//builder.Services.AddScoped<IDeliveryRepository, DeliveryRepository>();

//Config session Login
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    //options.Cookie.HttpOnly = true;
    //options.Cookie.IsEssential = true;
});

builder.Services.Configure<RouteOptions>(options =>
{
    options.ConstraintMap.Add("matconst", typeof(MatriculeRouteConstraint));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();
app.UseSession();

//Implémentation des Custom Middlewares
//app.UseRedirectIfNotConnected();

//Middleware
//app.Use(async (context, next) =>
//{
//    var id = context.Session.GetInt32("UserId");
//    var isLoginPage = context.Request.Path.Value?.ToLower().Contains("login");

//    if(!id.HasValue && (!isLoginPage.HasValue || !isLoginPage.Value))
//    {
//        context.Response.Redirect("/login");
//        return;
//    }

//    await next.Invoke(context);
//});

app.MapRazorPages();

app.Run();
