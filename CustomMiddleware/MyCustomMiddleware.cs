﻿
namespace MiddlewareExample.CustomMiddleware
{
    public class MyCustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("My custom middleware - Starts");
            await next(context);
            await context.Response.WriteAsync("My custom middleware - Ends");
        }
    }
}
