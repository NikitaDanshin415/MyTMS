using Microsoft.AspNetCore.Builder;

namespace TMS.WebApi.Middleware
{
    public static class CustomExceptionHandlerMiddlewareExtrensions
    {
        public static IApplicationBuilder UseCustomExeptionHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomExceptionHandlerMiddleware>();
        }
    }
}