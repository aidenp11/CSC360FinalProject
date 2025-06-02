using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC360FinalProject.Factories
{
	// Concrete product for a Xbox
	public class Xbox : IProduct
	{
		public string Name => "Console";
		public float Price => 499.99f;
	}
}
