using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC360FinalProject.Observers
{
	// Concrete observer for stock alerts
	internal class StockAlert : IStockObserver
	{
		public void Update(int stock)
		{
			Console.WriteLine($"[Stock Alert] Stock updated to: {stock}");
		}
	}
}
