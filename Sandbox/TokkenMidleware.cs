using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Sandbox
{
    public class TokkenMidleware
    {
        private readonly RequestDelegate _next;
        string pattern;

        public TokkenMidleware(RequestDelegate next, string pattern)
        {
            _next = next;
            this.pattern = pattern;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var token = context.Request.Query["token"];

            if (token != pattern)
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync("Invalid token");
            } else
            {
                await _next.Invoke(context);
            }
        }
    }
}
