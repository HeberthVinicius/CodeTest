using CodeTest.Context;
using CodeTest.Repositories;
using CodeTest.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configurar opções de visualização
builder.Services.AddRazorPages(options =>
{
    options.RootDirectory = "/src/Views";
});

// Add services to the container.
builder.Services.AddDbContext<DBCONCESSIONARIAContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("StandardConnection")));

builder.Services.AddScoped<IComissaoService, ComissaoService>();
builder.Services.AddScoped<IComissaoRepository, ComissaoRepository>();


builder.Services.AddControllersWithViews();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Comissao/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Comissao}/{action=Index}/{id?}");

app.Run();
