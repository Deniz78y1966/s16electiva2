using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    var holaMundo = new HolaMundo();
    return holaMundo.GetMessage();
});

//execute on server
app.Run();

/*
class Program
{
    static void Main(string[] args)
    {
        var holaMundo = new HolaMundo();
        Console.WriteLine(holaMundo.GetMessage());
    }
}
*/