using System;
namespace TheSaverAPI.Model
{
	public class Product
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Color { get; set; }

		public Brand Brand { get; set; }
	}
}

