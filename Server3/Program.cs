var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async ctx =>
{
    ctx.Response.ContentType = "text/html; charset=utf-8";

    var r = new Random();
    var num = r.Next();

    var date = DateTime.Now;

    await ctx.Response.WriteAsync($@"<!DOCTYPE html>
    <html>
    <head>
        <title>ASP.NET Core</title>
    </head>
    <body>
        <h1>ASP.NET Core</h1>
        <p>random number: {num}</p>
        <h2>date</h2>
        <p>{date}</p>
    </body>
    </html>
    ");
});

app.Run();
