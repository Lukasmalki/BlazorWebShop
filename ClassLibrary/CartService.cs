using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blazored.LocalStorage;

namespace ClassLibrary
{
	public class CartService
	{
		private readonly ILocalStorageService _localStorage;

		public List<Product> ProductsInCart = new List<Product>();

		public CartService(ILocalStorageService localStorage)
		{
			_localStorage = localStorage;
		}

		public async Task AddToCart(Product product)
		{
			ProductsInCart.Add(product);
			await _localStorage.SetItemAsync("cart", ProductsInCart);
		}

		public async Task ClearAllFromCart()
		{
			ProductsInCart.Clear();
			await _localStorage.RemoveItemAsync("cart");
		}
	}
}
