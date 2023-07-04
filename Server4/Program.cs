using MySql.Data.MySqlClient;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

const string connStr = "server=localhost;user=mysql;database=mysql;port=3306;password=*;";

app.MapGet("/", async ctx =>
{
  ctx.Response.ContentType = "text/html; charset=utf-8";
  using var conn = new MySqlConnection(connStr);
  await conn.OpenAsync();
  // SQLの実行
  var sql = "SELECT id, name, weight FROM cats";
  var cmd = new MySqlCommand(sql, conn);
  using var reader = await cmd.ExecuteReaderAsync();
  // HTMLの猫表部分を組み立てる
  var cats  = new StringBuilder();
  if (reader.HasRows)
  {
    while (reader.Read())
    {
      cats.AppendLine($"<tr><td>{reader[0]}</td><td>{reader[1]}</td><td>{reader[2]}</td></tr>");
    }
  }
  await ctx.Response.WriteAsync($@"<!DOCTYPE html>
<html>
  <head>
    <title>ねこたち</title>
  </head>
  <body>
    <table>
      <thead>
        <tr>
          <th>ID</th>
          <th>なまえ</th>
          <th>重さ(g)</th>
        </tr>
      </thead>
      <tbody>
{cats}
      </tbody>
    </table>
  </body>
</html>");
});
app.Run();