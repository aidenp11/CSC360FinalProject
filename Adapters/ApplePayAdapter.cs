using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC360FinalProject.Adapters
{
	// Adapter that converts ApplePay to our interface and allows the ApplePay class to be used as a payment provider
	public class ApplePayAdapter : IPaymentProvider
	{
		private ApplePay _applePay = new ApplePay();

		public void Pay(float amount)
		{
			_applePay.Charge((double)amount);
		}

	}
}
