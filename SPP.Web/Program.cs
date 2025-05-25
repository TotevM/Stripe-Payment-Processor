
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SPP.Data.Models;
using StripePaymentProcessor.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders()
	.AddDefaultUI();

builder.Services.AddRazorPages();

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
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
app.ApplyMigrations();
app.MapRazorPages();

app.Run();

public static class ApplicationBuilderExtensions
{
	public static IApplicationBuilder ApplyMigrations(this IApplicationBuilder app)
	{
		using IServiceScope serviceScope = app.ApplicationServices.CreateScope();

		ApplicationDbContext dbContext = serviceScope
			.ServiceProvider
			.GetRequiredService<ApplicationDbContext>()!;
		dbContext.Database.Migrate();

		return app;
	}
} //TODO: move into the extension project