using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
namespace Sandbox
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await _next.Invoke(context);
            if (context.Response.StatusCode == 403)
            {
                await context.Response.WriteAsync("Acces denied");
            } else if (context.Response.StatusCode == 404)
            {
                await context.Response.WriteAsync("Page not found");
            }
        }
    }
}
