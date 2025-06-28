using _11Demo_Filters.Filter;

namespace _11Demo_Filters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<LoggingActionFilter>();
            builder.Services.AddScoped<DynamicLayoutFilter>();

            var app = builder.Build();

            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}
