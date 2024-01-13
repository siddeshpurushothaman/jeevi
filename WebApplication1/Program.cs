using BusinessLogic.Interface;
using BusinessLogic.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Runtime.CompilerServices;
using WebAppSettings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

const string configurationfile = @"Configurations\globalConfiguration.json";
builder.Host.ConfigureAppConfiguration(config =>
{
    config.AddJsonFile(configurationfile);
});

builder.Services.Configure<GlobalConfiguration>(builder.Configuration.GetSection("GlobalConfiguration"));
builder.Services.AddSingleton(resolver => resolver.GetRequiredService<IOptions<GlobalConfiguration>>().Value);
builder.Services.AddControllers();
builder.Services.AddScoped<IElectronicWebService, ElectronicWebService>();
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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
