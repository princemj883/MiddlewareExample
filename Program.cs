using MiddlewareExample.CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<MyCustomMiddleware>();
var app = builder.Build();

//middelware 1
app.Use(async (HttpContext context, RequestDelegate next) => {
    await context.Response.WriteAsync("Hello");
    await next(context);
});

// middelware 2
app.UseMiddleware<MyCustomMiddleware>();

app.Run();
