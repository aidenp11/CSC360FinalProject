using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC360FinalProject.Adapters
{
	// Simulates using Apple Pay as a payment option
	public class ApplePay
	{
		public void Charge(double amount)
		{
			Console.WriteLine($"[Apply Pay] Charged {amount:C} successfully.");
		}
	}
}
