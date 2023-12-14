using Microsoft.AspNetCore.Diagnostics;

namespace webapp.Middlewares
{
    public class DevelopmentHeaderMiddleware
    {
        private readonly RequestDelegate _next;

        public DevelopmentHeaderMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Try and retrieve the error from the ExceptionHandler middleware
            var exceptionDetails = context.Features.Get<IExceptionHandlerFeature>();
            var ex = exceptionDetails?.Error;

            if (ex != null)
            {
                context.Response.Headers.Add("X-Development-Error", "true");
            }

            try
            {
                await _next(context);
            }
            catch (Exception)
            {
                context.Response.Headers.Add("X-Development-Error", "true");
                throw;
            }
            
        }
    }
}