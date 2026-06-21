using Microsoft.EntityFrameworkCore;
using SalesMS.DAL.Context;
using SalesMS.BLL.Services;

var builder = WebApplication.CreateBuilder(args);

// تسجيل DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer("Server=.;Database=SalesMS_DB;Trusted_Connection=True;TrustServerCertificate=True"));

// تسجيل Services
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<CustomerService>();
builder.Services.AddScoped<OrderService>();
builder.Services.AddScoped<OrderItemService>();

// إضافة Controllers
builder.Services.AddControllers();

// Swagger (اختياري لكن مهم)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// تفعيل Swagger
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();