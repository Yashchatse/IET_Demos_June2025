using Microsoft.AspNetCore.Mvc.Filters;

namespace _15Sessions.Filters
{
    public class Auth : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var userDetailsToken = context.HttpContext.Session.GetString("Token");
            if (userDetailsToken == null)
            {
                context.HttpContext.Response.Redirect("/Login/SignIn");
            }
        }
    }
}
