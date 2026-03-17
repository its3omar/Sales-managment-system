using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using SalesMS.DAL.Context;
using SalesMS.BLL.Services;

namespace SalesMS.WinForms
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            // تسجيل DbContext
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer("Server=.;Database=SalesMS_DB;Trusted_Connection=True;TrustServerCertificate=True"));

            // تسجيل الـ Services
            services.AddScoped<CustomerService>();
            services.AddScoped<ProductService>();
            services.AddScoped<OrderService>();
            services.AddScoped<OrderItemService>();
            //services.AddScoped<OrderItemService>();
       
            // تسجيل الفورم
            services.AddTransient<LoginForm>();
            services.AddTransient<AdminForm>();
            services.AddTransient<AdminSaveProductForm>();
            services.AddTransient<DepositeForm>();
            services.AddTransient<SaveCustomerForm>();
            services.AddTransient<ShopForm>();
            services.AddTransient<SMainForm>();
            services.AddTransient<ValuedCustomerForm>();
            services.AddTransient<BestSellingForm>();
            services.AddTransient <OutOfStockForm>();
            services.AddTransient<AdminStatisticsForm>();
            services.AddTransient<CustomerOrdersForm>();



            ServiceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();

            Application.Run(ServiceProvider.GetRequiredService<LoginForm>());
        }
    }
}