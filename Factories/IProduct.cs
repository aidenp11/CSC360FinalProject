using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC360FinalProject.Factories
{
	// Abstract factory interface for products with a name and a price
	public interface IProduct
	{
		string Name { get; }
		float Price { get; }
	}
}
