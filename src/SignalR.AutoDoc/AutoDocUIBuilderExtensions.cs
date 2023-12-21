using Microsoft.AspNetCore.Builder;

namespace SignalR.AutoDoc
{
    public static class AutoDocUIBuilderExtensions
    {
        public static IApplicationBuilder UseAutoDocUI(this IApplicationBuilder app)
        {
            return app.UseMiddleware<AutoDocUIMiddleware>();
        }
    }
}
