using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC360FinalProject.Observers
{
	// Subject that holds the stock information and notifies observers of changes
	public class ProductStock
	{
		private List<IStockObserver> _observers = new();
		public int _stock { get; set; }

		public void AddObserver(IStockObserver observer) => _observers.Add(observer);


		public void RemoveObserver(IStockObserver observer) => _observers.Remove(observer);

		public void SetStock(int newStock)
		{
			_stock = newStock;
			Notify();
		}

		private void Notify()
		{
			foreach (var observer in _observers)
			{
				observer.Update(_stock);
			}
		}
	}
}
