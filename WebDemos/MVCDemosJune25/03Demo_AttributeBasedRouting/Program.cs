namespace _03Demo_AttributeBasedRouting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            app.MapControllers(); // Middleware for Attribute Based Routing

            app.Run();
        }
    }
}
