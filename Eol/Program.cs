using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Eol.Models;
using Eol.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSignalR();

builder.Services.AddDbContext<EolContext>(
    dbContextOptions => dbContextOptions
        .UseMySql(
            builder.Configuration["ConnectionStrings:AZURE_SQL_CONNECTION"], 
            ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:AZURE_SQL_CONNECTION"]
        )
    )
);

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<EolContext>()
    .AddDefaultTokenProviders();

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Tells our Application how to handle real time updates with SignalR
app.UseEndpoints(endpoints =>
{
    endpoints.MapHub<ChatHub>("/chathub");
    // endpoints.MapHub<PvtHub>("/pvthub");
});
// app.MapHub<ChatHub>("/chatHub");

app.Run();












// // In Startup.cs, configure routing
// app.UseEndpoints(endpoints =>
// {
//     endpoints.MapHub<ChatHub>("/chathub");
//     endpoints.MapHub<DashboardHub>("/dashboardhub");
// });
