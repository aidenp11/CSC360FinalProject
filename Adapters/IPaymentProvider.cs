using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC360FinalProject.Adapters
{
	// Interface for payment providers expected to handle payments
	public interface IPaymentProvider
	{
		void Pay(float amount);
	}
}
