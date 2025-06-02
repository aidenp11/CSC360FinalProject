using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC360FinalProject.Adapters
{
	// Simulates using a credit card as a payment option
	public class CreditCard
	{
		public void Charge(double amount)
		{
			Console.WriteLine($"[Credit Card] Charged {amount:C} successfully.");
		}
	}
}
