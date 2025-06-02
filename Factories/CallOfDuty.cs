using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC360FinalProject.Factories
{
	// Concrete product for Call of Duty
	public class CallOfDuty : IProduct
	{
		public string Name => "Call of Duty";
		public float Price => 59.99f;
	}
}
