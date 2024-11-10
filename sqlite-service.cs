// sqlite-service.cs
using System;
using System.Data.SQLite;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.MapGet("/sqlite", async context =>
{
    using var connection = new SQLiteConnection("Data Source=allxend.db");
    connection.Open();

    var command = new SQLiteCommand("CREATE TABLE IF NOT EXISTS data (id INTEGER PRIMARY KEY, name TEXT);", connection);
    command.ExecuteNonQuery();

    command = new SQLiteCommand("INSERT INTO data (name) VALUES ('Sample Data');", connection);
    command.ExecuteNonQuery();

    await context.Response.WriteAsync("SQLite Service: Data inserted successfully!");
});

app.Run("http://localhost:8000");
