using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	public class UserInfo
	{
		[Required(ErrorMessage = "Fyll i fullständigt namn.")]
		public string? Fullname { get; set; }

		[Required(ErrorMessage = "Fyll i address")]
		public string? StreetAdress { get; set; }

		[Required(ErrorMessage = "Fyll i postkod.")]
		[Range(10000, 99999, ErrorMessage = "Måste vara 5 siffrig postkod.")]
		public string? PostalCode { get; set; }

		[Required(ErrorMessage = "Fyll i stad.")]
		public string? City { get; set; }
	}
}
