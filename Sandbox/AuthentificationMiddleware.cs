using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
namespace Sandbox
{
    public class AuthentificationMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthentificationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var token = context.Request.Query["token"];
            if (string.IsNullOrWhiteSpace(token))
            {
                context.Response.StatusCode = 403;
            } else
            {
                await _next.Invoke(context);
            }
        }
    }
}
