using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using YGate.Postgresql.Entityframework;
using YGate.Server.Entities;
using YGate.Server.Entities.Abstracts;
using YGate.Shared.Concretes;
using YGate.Postgresql.Entityframework.Concretes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddScoped<IGenericDataOperationsBase<Category>, CategoryOperations>();
builder.Services.AddScoped<IGenericDataOperationsBase<Product>, ProductOperations>();
builder.Services.AddScoped<IGenericDataOperationsBase<Point>, PointOperations>();
builder.Services.AddScoped<IGenericDataOperationsBase<CorporateCustomer>, CorporateCustomerOperations>();
builder.Services.AddScoped<IGenericDataOperationsBase<IndividualCustomer>, IndividualCustomerOperations>();
builder.Services.AddScoped<IGenericDataOperationsBase<Employee>, EmployeeOperations>();
builder.Services.AddScoped<IGenericDataOperationsBase<Region>, RegionOperations>();
builder.Services.AddScoped<IGenericDataOperationsBase<Sale>, SaleOperations>();
builder.Services.AddScoped<IGenericDataOperationsBase<PayType>, PayTypeOperations>();
builder.Services.AddScoped<IGenericDataOperationsBase<User>, UserOperations>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();



app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
