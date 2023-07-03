var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/zarigani", () => "Hello ザリガニガニ");
app.MapGet("/piyo", async ctx =>
{
    ctx.Response.ContentType = "text/plain; charset=utf-8";
    await ctx.Response.WriteAsync("Hello くわがた!");
});
app.MapGet("/hoge", async ctx =>
{
    ctx.Response.ContentType = "text/html; charset=utf-8";
    await ctx.Response.WriteAsync($@"<!DOCTYPE html>
    <html>
        <head>
            <meta charset=""utf-8"">
            <title>hoge</title>
        </head>
        <body>
            <h1>hoge</h1>
            <p>わっしょい祭りだわっしょい</p>
        </body>
    </html>
    ");
});

app.Run();