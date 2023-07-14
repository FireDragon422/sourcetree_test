using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        
        app.UseDeveloperExceptionPage();
        

        app.MapGet("/", () => "Hello World");
        app.Run();
    }
}