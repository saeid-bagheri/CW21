using CW21.DAL.Context;
using CW21.Repositories;
using CW21.Repositories.Doctors;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(option =>
option.UseSqlServer("Data Source=.;Initial Catalog=db_Maktab_CW21;User Id=sa;Password=6925;TrustServerCertificate=True"));

builder.Services.AddScoped<IPatientRepository, PatientRepository>();
builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();


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

app.MapAreaControllerRoute(
  areaName: "DoctorArea",
  name: "areas",
  pattern: "{area:exists}/{controller=Account}/{action=LoginDoctor}/{id?}");




app.Run();
