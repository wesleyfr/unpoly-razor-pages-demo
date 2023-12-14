namespace webapp.Middlewares
{
    public class SlowResponseMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly int? _delayMilliseconds = null;

        public SlowResponseMiddleware(RequestDelegate next, int? delayMilliseconds = null)
        {
            _next = next;
            _delayMilliseconds = delayMilliseconds;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await Task.Delay(_delayMilliseconds ?? 700);

            await _next(context);
        }
    }
}