using CSC360FinalProject.Adapters;
using CSC360FinalProject.Factories;
using CSC360FinalProject.Observers;


Console.WriteLine("Welcome to the Aiden's Online Game Store!\n");

// Create product factories
IProductFactory consoleFactory = new ConsoleFactory();
IProductFactory gameFactory = new GameFactory();

// Set up observer for stock tracking
var stock = new ProductStock();
var stockObserver = new StockAlert();
stock.AddObserver(stockObserver);

var productStocks = new Dictionary<string, int>
		{
			{ "Xbox", 4 },
			{ "Playstation", 7 },
			{ "Minecraft", 17 },
			{ "Call Of Duty", 12 }
		};

while (true)
{
	Console.WriteLine("Select a product category:");
	Console.WriteLine("1. Consoles");
	Console.WriteLine("2. Games");
	Console.WriteLine("3. Exit");

	Console.Write("Choice: ");
	string choice = Console.ReadLine();
	Console.WriteLine();

	IProduct product = null;

	switch (choice)
	{
		case "1":
			Console.WriteLine("Available Consoles:");
			Console.WriteLine("1. Xbox");
			Console.WriteLine("2. Playstation");

			Console.Write("Choose product: ");
			string cChoice = Console.ReadLine();

			switch (cChoice)
			{
				case "1":
					product = consoleFactory.CreateProduct("Xbox");
					break;
				case "2":
					product = consoleFactory.CreateProduct("Playstation");
					break;
				default:
					Console.WriteLine("Invalid console choice.\n");
					continue;
			}
			break;
		case "2":
			Console.WriteLine("Available Games:");
			Console.WriteLine("1. Minecraft");
			Console.WriteLine("2. Call Of Duty");

			Console.Write("Choose product: ");
			string gChoice = Console.ReadLine();

			switch (gChoice)
			{
				case "1":
					product = gameFactory.CreateProduct("Minecraft");
					break;
				case "2":
					product = gameFactory.CreateProduct("CallOfDuty");
					break;
				default:
					Console.WriteLine("Invalid game choice.\n");
					continue;
			}
			break;

		case "3":
			Console.WriteLine("Goodbye!");
			return;

		default:
			Console.WriteLine("Invalid choice.\n");
			continue;
	}

	if (product == null)
	{
		Console.WriteLine("Product not found.\n");
		continue;
	}

	if (!productStocks.ContainsKey(product.Name) || productStocks[product.Name] <= 0)
	{
		Console.WriteLine($"Sorry, {product.Name} is out of stock.\n");
		continue;
	}

	Console.WriteLine($"\nYou selected: {product.Name} - ${product.Price}");
	productStocks[product.Name]--;
	stock.SetStock(productStocks[product.Name]);

	Console.Write("Would you like to proceed to payment? (y/n): ");
	string payChoice = Console.ReadLine()?.ToLower();

	if (payChoice == "y")
	{
		Console.WriteLine("Which payment method would you like to use?");
		Console.WriteLine("1. Apple Pay");
		Console.WriteLine("2. Credit Card");
		IPaymentProvider paymentProvider;
		string paymentTypeSelection = Console.ReadLine();
		if (paymentTypeSelection == "1")
		{
			IPaymentProvider payment = new ApplePayAdapter();
			Console.WriteLine("Using Apple Pay for payment.");
			payment.Pay(product.Price);
			Console.WriteLine("Thank you for your purchase!\n");
		}
		else if (paymentTypeSelection == "2")
		{
			IPaymentProvider payment = new CreditCardAdapter();
			Console.WriteLine("Using Credit Card for payment.");
			payment.Pay(product.Price);
			Console.WriteLine("Thank you for your purchase!\n");
		}
		else
		{
			Console.WriteLine("Invalid payment method selected. Purchase canceled.\n");
			productStocks[product.Name]++;
			stock.SetStock(productStocks[product.Name]);
			continue;
		}
	}
	else
	{
		Console.WriteLine("Purchase canceled.\n");
		productStocks[product.Name]++;
		stock.SetStock(productStocks[product.Name]);
	}

	Console.WriteLine("------------------------------\n");
}


// Old test code to make sure all my patterns functioned correctly

//IProductFactory gameFactory = new GameFactory();
//IProduct minecraft = gameFactory.CreateProduct("Minecraft");
//IProduct callOfDuty = gameFactory.CreateProduct("CallOfDuty");
////IProduct nullGame = gameFactory.CreateProduct("nullGame");

//IProductFactory consoleFactory = new ConsoleFactory();
//IProduct xbox = consoleFactory.CreateProduct("Xbox");
//IProduct playstation = consoleFactory.CreateProduct("Playstation");
////IProduct nullConsole = consoleFactory.CreateProduct("nullConsole");

//IPaymentProvider applePay = new ApplePayAdapter();
//applePay.Pay(100.0f);

//var stock = new ProductStock();
//stock.AddObserver(new StockAlert()); 
//stock.SetStock(5);



