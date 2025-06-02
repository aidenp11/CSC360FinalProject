using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC360FinalProject.Factories
{
	// Concrete product for a Playstation
	public class Playstation : IProduct
	{
		public string Name => "PlayStation";
		public float Price => 399.99f;

	}
}
