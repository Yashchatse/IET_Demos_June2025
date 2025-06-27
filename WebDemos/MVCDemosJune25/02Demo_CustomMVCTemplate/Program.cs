namespace _02Demo_CustomMVCTemplate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //builder.Services.AddControllers();
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            //Middleware pipeline configuration
            //Routing Configure :  Conventional Based Routing
            
            //app.MapDefaultControllerRoute(); // This sets up the default route for MVC applications: "\Home\Index"

            app.MapControllerRoute(              
                name: "default",
                pattern: "{controller=User}/{action=Index}/{id?}"
                );

            app.MapControllerRoute(
                name: "bvs",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            app.MapControllerRoute(
                name: "bvs2",
                pattern: "{controller=Home}/{action=UpdateEMP}/{empId}"
                );
            app.MapControllerRoute(
                name: "route1",
                pattern: "{controller=Home}/{action=Index}/{un}/{pwd}"
                );
            app.Run();
        }
    }
}
