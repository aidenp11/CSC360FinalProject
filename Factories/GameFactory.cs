using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC360FinalProject.Factories
{
	// Concrete factory for creating games
	public class GameFactory : IProductFactory
	{
		public IProduct CreateProduct(string type)
		{
			switch (type)
			{
				case "Minecraft":
					{
						var minecraft = new Minecraft();
						Console.WriteLine($"Created game: {minecraft.Name} with price: {minecraft.Price}");
						return minecraft;
					}
				case "CallOfDuty":
					{
						var callOfDuty = new CallOfDuty();
						Console.WriteLine($"Created game: {callOfDuty.Name} with price: {callOfDuty.Price}");
						return callOfDuty;
					}
			}
			throw new ArgumentException($"Unknown game: {type}");
		}

	}
}

