using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC360FinalProject.Factories
{
	// Concrete product for creating consoles
	public class ConsoleFactory : IProductFactory
	{
		public IProduct CreateProduct(string type)
		{
			switch (type)
			{
				case "Xbox":
					{
						var xbox = new Xbox();
						Console.WriteLine($"Created console: {xbox.Name} with price: {xbox.Price}");
						return xbox;
					}
				case "Playstation":
					{
						var playstation = new Playstation();
						Console.WriteLine($"Created console: {playstation.Name} with price: {playstation.Price}");
						return playstation;
					}
			}
			throw new ArgumentException($"Unknown console: {type}");
		}
	}
}
