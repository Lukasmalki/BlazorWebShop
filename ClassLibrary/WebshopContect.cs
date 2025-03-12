using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

	public class WebshopContext : IdentityDbContext<WebshopUser>
	{
		public WebshopContext(DbContextOptions<WebshopContext> options) : base(options) { }
		public DbSet<Product> Products { get; set; }
	}
	public class WebshopUser : IdentityUser
	{
		//Add more properties for user here....
	}
}
