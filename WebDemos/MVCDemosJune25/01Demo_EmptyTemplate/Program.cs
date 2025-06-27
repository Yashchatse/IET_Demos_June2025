namespace _01Demo_EmptyTemplate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            #region Middlewares
            //app.MapGet("/", () => "Hello World!");
            //app.MapGet("/", () => "<input type ='text'/>");

            //app.MapGet("/",()=>"Hello World with HTTP GET");
            //app.MapPost("/",()=>"Hello World with HTTP POST");
            //app.MapPut("/",()=>"Hello World with HTTP PUT");
            //app.MapDelete("/",()=>"Hello World with HTTP DELETE"); 
            #endregion

            app.Use(async (context,next) => {
               await context.Response.WriteAsync("Hello Hugh Jakman!!");
                await next.Invoke(context);
                await context.Response.WriteAsync("\nHello World!!");
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("\nHello Ben Stiller!!");
            });

            app.Run();
        }
    }
}
