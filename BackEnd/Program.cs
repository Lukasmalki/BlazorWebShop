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
					Name = "Pedri tr�ja 24/25",
					Description = "Denna Barcelona bortatr�ja f�r s�songen 2024/2025 �r designad f�r att hylla den unga superstj�rnan, Pedri. Tr�jan b�r klubbens traditionella f�rger och symboliserar hans utveckling som en viktig spelare f�r laget. Perfekt f�r b�de samlare och fans som vill visa sitt st�d f�r Pedri och FC Barcelona p� bortaplan.",
					Price = 2500,
					ImgURL = "/images/pedripic.png"
				},
				new Product
				{
					Id = 2,
					Name = "Messi tr�ja 22/23",
					Description = "Denna Paris Saint-Germain hemmatr�ja f�r s�songen 2022/2023 �r en hyllning till en av v�rldens st�rsta fotbollsstj�rnor, Lionel Messi. Tr�jan representerar Messi under hans legendariska tid i PSG, d�r han forts�tter att s�tta standarden f�r fotbollens st�rsta talanger. En m�st-have f�r alla Messi- och PSG-fans, designad f�r att maximera komfort och prestanda p� planen.",
					Price = 2200,
					ImgURL = "images/messipic.webp"
				},
				new Product
				{
					Id = 3,
					Name = "Raphinha tr�ja 24/25",
					Description = "Upplev den moderna Barcelona bortatr�jan f�r s�songen 2024/2025, designad f�r att fira den brasilianske yttern Raphinha. Denna tr�ja f�ngar Raphinhas passion och energi p� planen, med en stilren design i Barcelonas ikoniska bortaf�rger. Ett utm�rkt val f�r fans som vill visa sitt st�d f�r b�de klubben och Raphinha n�r han dominerar p� sin position.",
					Price = 2500,
					ImgURL = "/images/raphinhapic.png"
				},
				new Product
				{
					Id = 4,
					Name = "Mbapp� tr�ja 23/24",
					Description = "Denna Paris Saint-Germain tr�ja f�r s�songen 2023/2024 b�r st�mpeln av en av v�rldens b�sta anfallare, Kylian Mbapp�. Tr�jan �r designad med en stilfull och funktionell look, vilket g�r den till ett utm�rkt val f�r b�de spel och vardagsbruk. B�r den med stolthet och visa ditt st�d f�r PSG och Mbapp�, som forts�tter att vara en nyckelspelare f�r laget.",
					Price = 1800,
					ImgURL = "/images/mbappepic.webp"
				},
				new Product
				{
					Id = 5,
					Name = "Neymar tr�ja 20/21",
					Description = "F�reviga Neymar Jr:s tid i Paris Saint-Germain med denna tr�ja fr�n s�songen 2020/2021. Tr�jan representerar Neymar n�r han dominerade p� planen med sitt exceptionella spel och kreativitet. Med sin exklusiva design och PSG:s f�rger �r detta en perfekt tr�ja f�r att hedra en av fotbollens st�rsta talanger.",
					Price = 1600,
					ImgURL = "/images/neymarpic.webp"
				},
				new Product
				{
					Id = 6,
					Name = "De Bruyne tr�ja 22/23",
					Description = "Manchester Citys De Bruyne tr�ja f�r s�songen 2022/2023 �r designad f�r att spegla den belgiska mittf�ltsm�starens briljans. Kevin De Bruyne har l�nge varit en nyckelspelare f�r Manchester City, och denna tr�ja hyllar hans oslagbara passningar och spelf�rst�else. En perfekt tr�ja f�r alla City-fans som vill visa sitt st�d f�r denna fantastiska spelare.",
					Price = 2100,
					ImgURL = "/images/debruynepic.webp"
				},
				new Product
				{
					Id = 7,
					Name = "Salah tr�ja 22/23",
					Description = "Denna Liverpool tr�ja fr�n s�songen 2022/2023 �r designad f�r att hylla Mohamed Salah, en av v�rldens mest explosiva och m�lmedvetna anfallare. Tr�jan representerar Salah n�r han leder Liverpool fram�t med sin snabbhet, skicklighet och m�lproduktion. En sj�lvklar tr�ja f�r alla Liverpool- och Salah-fans som vill visa sitt st�d f�r den egyptiska stj�rnan.",
					Price = 1700,
					ImgURL = "/images/salahpic.webp"
				},
				new Product
				{
					Id = 8,
					Name = "Lewandowski tr�ja 21/22",
					Description = "F�r alla Barcelona-fans �r denna Lewandowski tr�ja fr�n s�songen 2021/2022 en hyllning till en av de b�sta anfallarna i v�rlden. Robert Lewandowski forts�tter att vara en central figur i Barcelona, och denna tr�ja representerar hans passion och m�lmedvetenhet p� planen. En fantastisk tr�ja f�r att fira Lewandowskis framg�ngar med Bar�a.",
					Price = 600,
					ImgURL = "/images/lewapic.webp"
				},
				new Product
				{
					Id = 9,
					Name = "Haaland tr�ja 23/24",
					Description = "Manchester City tr�ja fr�n s�songen 2023/2024, designad f�r att hylla den norska sensationelle anfallaren Erling Haaland. Haaland, som �r k�nd f�r sin kraftfulla spelstil och m�lproduktion, b�r denna tr�ja som ett symbol f�r sin dominans p� planen. Perfekt f�r alla Manchester City- och Haaland-fans som vill visa sitt st�d f�r den unga stj�rnan.",
					Price = 2300,
					ImgURL = "/images/haalandpic.png"
				},
				new Product
				{
					Id = 10,
					Name = "Kane tr�ja 21/22",
					Description = "Bayern M�nchens tr�ja f�r s�songen 2021/2022 �r designad f�r att hylla Harry Kane, en av de mest p�litliga m�lg�rarna i modern fotboll. Efter hans �verg�ng till Bayern M�nchen b�r Kane denna tr�ja som en del av sitt nya kapitel i den tyska storklubben. Tr�jan representerar Kanes vilja att er�vra nya h�jder i Bundesliga och Europa.",
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
