//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ClassLibrary
//{
//	public class ProductService
//	{
//		public List<Product> Products = new List<Product>
//		{
//			new Product { Id = 1, Name = "Pedri tröja 24/25", Description = "Barcelona, Pedri 24/25 bortatröja", Price = 2500, ImgURL = "/images/pedripic.png"},
//			new Product { Id = 2, Name = "Messi tröja 22/23", Description = "Paris Saint-Germain, Messi 22/23 hemmatröja", Price = 2200, ImgURL = "images/messipic.webp" },
//			new Product { Id = 3, Name = "Raphinha tröja 24/25", Description = "Barcelona, Raphinha 24/25 bortatröja", Price = 200, ImgURL = "/images/raphinhapic.png"},
//			new Product { Id = 4, Name = "Mbappé tröja 23/24", Description = "Paris Saint-Germain, Mbappé 23/24 tröja", Price = 1800, ImgURL = ""},
//			new Product { Id = 5, Name = "Neymar tröja 20/21", Description = "Paris Saint-Germain, Neymar 20/21 tröja", Price = 1600 },
//			new Product { Id = 6, Name = "De Bruyne tröja 22/23", Description = "Manchester City, De Bruyne 22/23 tröja", Price = 2100 },
//			new Product { Id = 7, Name = "Salah tröja 22/23", Description = "Liverpool, Salah 22/23 bortatröja", Price = 1700 },
//			new Product { Id = 8, Name = "Lewandowski tröja 21/22", Description = "Bayern München, Lewandowski 21/22 hemmatröja", Price = 2400 },
//			new Product { Id = 9, Name = "Haaland tröja 23/24", Description = "Manchester City, Haaland 23/24 hemmatröja", Price = 2300 },
//			new Product { Id = 10, Name = "Zlatan tröja 21/22", Description = "AC Milan, Zlatan 21/22 tröja", Price = 2200 }
//		};

//		public List<Product> GetProducts()
//		{
//			return Products;
//		}

//		// Hämta en produkt baserat på id
//		public Product? GetProduct(int id)
//		{
//			return Products?.FirstOrDefault(p => p.Id == id);
//		}
//	}
//}
