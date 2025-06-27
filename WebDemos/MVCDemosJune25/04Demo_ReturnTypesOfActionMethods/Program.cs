namespace _04Demo_ReturnTypesOfActionMethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            // "/"
            // "/Home"
            // "/Home/Index"
            // "/Home/Index/{id?}"
            app.MapDefaultControllerRoute();
            app.Run();
        }
    }
}
