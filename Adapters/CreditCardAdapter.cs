using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC360FinalProject.Adapters
{
	// Adapter that converts CreditCard to our interface and allows the CreditCard class to be used as a payment provider
	public class CreditCardAdapter : IPaymentProvider
	{
		private CreditCard _creditCard = new CreditCard();

		public void Pay(float amount)
		{
			_creditCard.Charge((double)amount);
		}

	}
}
