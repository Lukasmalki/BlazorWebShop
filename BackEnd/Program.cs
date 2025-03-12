using ClassLibrary;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BackEnd
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			//var connectionString = builder.Configuration.GetConnectionString("WebshopDb");
			//builder.Services.AddDbContext<WebshopContext>(options =>
			// options.UseSqlServer(connectionString));

			var app = builder.Build();

			app.UseSwagger();
			app.UseSwaggerUI();

			app.MapGet("/", () => "Hello World!");

			app.Run();
		}
	}
}
