using MovieTicket.Data;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using MovieTicket.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();



builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer
(builder.Configuration.GetConnectionString("DefaultConnectionString")));


builder.Services.AddScoped<IActorService, ActorService>();
//IServiceCollection services = new
//void ConfigureServices(IServiceCollection services)
//{
//    services.AddScoped<IActorService, IActorService>();
//}




var app = builder.Build();

//app.AddScoped<IActorService, IActorService>();

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


  //Insert Data 
AppDbIntilizer.Seed(app);


app.Run();
