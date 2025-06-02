using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC360FinalProject.Observers
{
	// Observer interface for observers to be notified of stock updates
	public interface IStockObserver
	{
		void Update(int stock);
	}
}
