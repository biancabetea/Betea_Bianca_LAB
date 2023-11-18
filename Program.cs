using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Betea_Bianca_LAB2.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages(options =>
{
    options.Conventions.AuthorizeFolder("/Books");

options.Conventions.AllowAnonymousToPage("/Books/Index");
options.Conventions.AllowAnonymousToPage("/Books/Details");
});
builder.Services.AddDbContext<Betea_Bianca_LAB2Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Betea_Bianca_LAB2Context") ?? throw new InvalidOperationException("Connection string 'Betea_Bianca_LAB2Context' not found.")));

builder.Services.AddDbContext<LibraryIdentityContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LibraryIdentityContextConnection") ?? throw new InvalidOperationException("Connection string 'LibraryIdentityContextConnection' not found.")));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
  .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<LibraryIdentityContext>();

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
app.UseAuthentication(); ;

app.UseAuthorization();

app.MapRazorPages();

app.Run();