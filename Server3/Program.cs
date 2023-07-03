var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async ctx =>
{
    ctx.Response.ContentType = "text/html; charset=utf-8";
    // ランダム
    var r = new Random();
    var num = r.Next();
    // 時刻
    var date = DateTime.Now;
    // テンプレート
    var template = "<!DOCTYPE html><html><head><meta charset=\"utf-8\"><title>インデックスページだよ</title></head><body><h1>ほげー</h1><h2>ランダム</h2><p>%num%</p><h2>時刻</h2><p>%date%</p></body></html>";
    await ctx.Response.WriteAsync(template.Replace("%num%", num.ToString()).Replace("%date%", date.ToString()));
});

app.Run();
