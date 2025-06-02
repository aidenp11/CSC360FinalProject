using CSC360FinalProject.Factories;
using CSC360FinalProject.Adapters;

IProductFactory gameFactory = new GameFactory();
IProduct minecraft = gameFactory.CreateProduct("Minecraft");
IProduct callOfDuty = gameFactory.CreateProduct("CallOfDuty");
//IProduct nullGame = gameFactory.CreateProduct("nullGame");

IProductFactory consoleFactory = new ConsoleFactory();
IProduct xbox = consoleFactory.CreateProduct("Xbox");
IProduct playstation = consoleFactory.CreateProduct("Playstation");
//IProduct nullConsole = consoleFactory.CreateProduct("nullConsole");

IPaymentProvider applePay = new ApplePayAdapter();
applePay.Pay(100.0f);


