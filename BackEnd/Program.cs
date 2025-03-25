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

			var app = builder.Build();


			app.MapGet("/", () => "Hello World!");
			app.MapGet("/products", () => TypedResults.Ok(ProductData.GetProducts()));
			app.MapGet("/products/{id}", (int id) =>
			{
				var product = ProductData.GetProduct(id);
				return TypedResults.Ok(product);
			});

			app.Run();
		}
	}

	public static class ProductData
	{
		public static List<Product> GetProducts()
		{
			return new List<Product>()
			{
				new Product
				{
					Id = 1,
					Name = "Pedri tröja 24/25",
					Description = "Denna Barcelona bortatröja för säsongen 2024/2025 är designad för att hylla den unga superstjärnan, Pedri. Tröjan bär klubbens traditionella färger och symboliserar hans utveckling som en viktig spelare för laget. Perfekt för både samlare och fans som vill visa sitt stöd för Pedri och FC Barcelona på bortaplan.",
					Price = 2500,
					ImgURL = "/images/pedripic.png"
				},
				new Product
				{
					Id = 2,
					Name = "Messi tröja 22/23",
					Description = "Denna Paris Saint-Germain hemmatröja för säsongen 2022/2023 är en hyllning till en av världens största fotbollsstjärnor, Lionel Messi. Tröjan representerar Messi under hans legendariska tid i PSG, där han fortsätter att sätta standarden för fotbollens största talanger. En måst-have för alla Messi- och PSG-fans, designad för att maximera komfort och prestanda på planen.",
					Price = 2200,
					ImgURL = "images/messipic.webp"
				},
				new Product
				{
					Id = 3,
					Name = "Raphinha tröja 24/25",
					Description = "Upplev den moderna Barcelona bortatröjan för säsongen 2024/2025, designad för att fira den brasilianske yttern Raphinha. Denna tröja fångar Raphinhas passion och energi på planen, med en stilren design i Barcelonas ikoniska bortafärger. Ett utmärkt val för fans som vill visa sitt stöd för både klubben och Raphinha när han dominerar på sin position.",
					Price = 2500,
					ImgURL = "/images/raphinhapic.png"
				},
				new Product
				{
					Id = 4,
					Name = "Mbappé tröja 23/24",
					Description = "Denna Paris Saint-Germain tröja för säsongen 2023/2024 bär stämpeln av en av världens bästa anfallare, Kylian Mbappé. Tröjan är designad med en stilfull och funktionell look, vilket gör den till ett utmärkt val för både spel och vardagsbruk. Bär den med stolthet och visa ditt stöd för PSG och Mbappé, som fortsätter att vara en nyckelspelare för laget.",
					Price = 1800,
					ImgURL = "/images/mbappepic.webp"
				},
				new Product
				{
					Id = 5,
					Name = "Neymar tröja 20/21",
					Description = "Föreviga Neymar Jr:s tid i Paris Saint-Germain med denna tröja från säsongen 2020/2021. Tröjan representerar Neymar när han dominerade på planen med sitt exceptionella spel och kreativitet. Med sin exklusiva design och PSG:s färger är detta en perfekt tröja för att hedra en av fotbollens största talanger.",
					Price = 1600,
					ImgURL = "/images/neymarpic.webp"
				},
				new Product
				{
					Id = 6,
					Name = "De Bruyne tröja 22/23",
					Description = "Manchester Citys De Bruyne tröja för säsongen 2022/2023 är designad för att spegla den belgiska mittfältsmästarens briljans. Kevin De Bruyne har länge varit en nyckelspelare för Manchester City, och denna tröja hyllar hans oslagbara passningar och spelförståelse. En perfekt tröja för alla City-fans som vill visa sitt stöd för denna fantastiska spelare.",
					Price = 2100,
					ImgURL = "/images/debruynepic.webp"
				},
				new Product
				{
					Id = 7,
					Name = "Salah tröja 22/23",
					Description = "Denna Liverpool tröja från säsongen 2022/2023 är designad för att hylla Mohamed Salah, en av världens mest explosiva och målmedvetna anfallare. Tröjan representerar Salah när han leder Liverpool framåt med sin snabbhet, skicklighet och målproduktion. En självklar tröja för alla Liverpool- och Salah-fans som vill visa sitt stöd för den egyptiska stjärnan.",
					Price = 1700,
					ImgURL = "/images/salahpic.webp"
				},
				new Product
				{
					Id = 8,
					Name = "Lewandowski tröja 21/22",
					Description = "För alla Barcelona-fans är denna Lewandowski tröja från säsongen 2021/2022 en hyllning till en av de bästa anfallarna i världen. Robert Lewandowski fortsätter att vara en central figur i Barcelona, och denna tröja representerar hans passion och målmedvetenhet på planen. En fantastisk tröja för att fira Lewandowskis framgångar med Barça.",
					Price = 600,
					ImgURL = "/images/lewapic.webp"
				},
				new Product
				{
					Id = 9,
					Name = "Haaland tröja 23/24",
					Description = "Manchester City tröja från säsongen 2023/2024, designad för att hylla den norska sensationelle anfallaren Erling Haaland. Haaland, som är känd för sin kraftfulla spelstil och målproduktion, bär denna tröja som ett symbol för sin dominans på planen. Perfekt för alla Manchester City- och Haaland-fans som vill visa sitt stöd för den unga stjärnan.",
					Price = 2300,
					ImgURL = "/images/haalandpic.png"
				},
				new Product
				{
					Id = 10,
					Name = "Kane tröja 21/22",
					Description = "Bayern Münchens tröja för säsongen 2021/2022 är designad för att hylla Harry Kane, en av de mest pålitliga målgörarna i modern fotboll. Efter hans övergång till Bayern München bär Kane denna tröja som en del av sitt nya kapitel i den tyska storklubben. Tröjan representerar Kanes vilja att erövra nya höjder i Bundesliga och Europa.",
					Price = 2200,
					ImgURL = "/images/kanepic.png"
				}
			};

		}
		public static Product? GetProduct(int id)
		{
			return GetProducts()?.FirstOrDefault(p => p.Id == id);
		}
	}


}
