using ClassLibrary;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace BackEnd
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			//builder.Services.AddEndpointsApiExplorer()
			//	.AddSwaggerGen()
			//	.AddRazorComponents()
			//	.AddInteractiveServerComponents();
			//builder.Services.AddControllers();


			//builder.Services.AddHttpClient();
			//builder.Services.AddScoped<ProductService>();


			//var connectionString = builder.Configuration.GetConnectionString("WebshopDb");
			//builder.Services.AddDbContext<WebshopContext>(options =>
			// options.UseSqlServer(connectionString));

			var app = builder.Build();

			app.MapGet("/", () => "Hello World!");
			app.MapGet("/products", () => TypedResults.Ok(ProductData.GetProducts()));
			app.MapGet("/products/{id}", (int id) =>
			{
				var product = ProductData.GetProduct(id);
				return TypedResults.Ok(product);
			});


			//app.UseSwagger();
			//app.UseSwaggerUI();

			//app.MapGet("/products", (ProductService productService) =>
			//{
			//	var products = productService.GetProducts();
			//	return Results.Ok(products);
			//});
			//app.MapGet("/products/{id:int}", (int id, ProductService productService) =>
			//{
			//	var product = productService.GetProduct(id);
			//	if (product == null)
			//	{
			//		return Results.NotFound();
			//	}
			//	return Results.Ok(product);
			//});
			//Console.WriteLine("API server is starting...");


			app.Run();
		}
	}

	public static class ProductData
	{
		public static List<Product> GetProducts()
		{
			return new List<Product>()
			{
			new Product { Id = 1, Name = "Pedri tr�ja 24/25", Description = "Barcelona, Pedri 24/25 bortatr�ja", Price = 2500, ImgURL = "/images/pedripic.png"},
			new Product { Id = 2, Name = "Messi tr�ja 22/23", Description = "Paris Saint-Germain, Messi 22/23 hemmatr�ja", Price = 2200, ImgURL = "images/messipic.webp" },
			new Product { Id = 3, Name = "Raphinha tr�ja 24/25", Description = "Barcelona, Raphinha 24/25 bortatr�ja", Price = 2500, ImgURL = "/images/raphinhapic.png"},
			new Product { Id = 4, Name = "Mbapp� tr�ja 23/24", Description = "Paris Saint-Germain, Mbapp� 23/24 tr�ja", Price = 1800, ImgURL = ""},
			new Product { Id = 5, Name = "Neymar tr�ja 20/21", Description = "Paris Saint-Germain, Neymar 20/21 tr�ja", Price = 1600 },
			new Product { Id = 6, Name = "De Bruyne tr�ja 22/23", Description = "Manchester City, De Bruyne 22/23 tr�ja", Price = 2100 },
			new Product { Id = 7, Name = "Salah tr�ja 22/23", Description = "Liverpool, Salah 22/23 bortatr�ja", Price = 1700 },
			new Product { Id = 8, Name = "Lewandowski tr�ja 21/22", Description = "Bayern M�nchen, Lewandowski 21/22 hemmatr�ja", Price = 2400 },
			new Product { Id = 9, Name = "Haaland tr�ja 23/24", Description = "Manchester City, Haaland 23/24 hemmatr�ja", Price = 2300 },
			new Product { Id = 10, Name = "Zlatan tr�ja 21/22", Description = "AC Milan, Zlatan 21/22 tr�ja", Price = 2200 }
			};
		}
		public static Product? GetProduct(int id)
		{
			return GetProducts()?.FirstOrDefault(p => p.Id == id);
		}
	}


}
