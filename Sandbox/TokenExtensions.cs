using Microsoft.AspNetCore.Builder;
namespace Sandbox
{
    public static class TokenExtensions
    {

        public static IApplicationBuilder UseToken(this IApplicationBuilder builder, string pattern)
        {
            return builder.UseMiddleware<TokkenMidleware>(pattern);
        }

    }
}
