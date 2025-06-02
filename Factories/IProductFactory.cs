using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC360FinalProject.Factories
{
	// Abstract factory for creating products
	public interface IProductFactory
	{
		IProduct CreateProduct(string productType);
	}
}
