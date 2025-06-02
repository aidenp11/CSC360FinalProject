using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC360FinalProject.Factories
{
	// Concrete product for Minecraft
	public class Minecraft : IProduct
	{
		public string Name => "Minecraft";
		public float Price => 19.99f;
	}
}
