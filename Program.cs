var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//middelware 1
app.Use(async (HttpContext context, RequestDelegate next) => {
    await context.Response.WriteAsync("Hello");
    await next(context);
});

// middelware 2
app.Run(async (HttpContext context) => {
    await context.Response.WriteAsync("Hello Again");
});

app.Run();
