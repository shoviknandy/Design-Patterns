using DesignPatternws;
using System.ComponentModel.DataAnnotations;

//ExecuteSingleton.Execute();


//var Logger = Factory.GetLogger(DesignPatternws.Logger.DB);
//Logger.Log("Thrown Exception in Line 24");


//var BuildVM = new Builder()
//              .setName("VM24")
//              .setGPU("GEForce RTX")
//              .setCPU("AMD Ryzen 5600H")
//              .setRam("16")
//              .Build();

//BuildVM.GetConfigDetails();


//var observer = new obspattern();
//observer.Execute();

//var paymentMethod = new Strategy();
//paymentMethod.paymentProcessor(new UPI());
//paymentMethod.pay(1200);

//paymentMethod.paymentProcessor(new NetBanking());
//paymentMethod.pay(1400);

Icoffee Coffee = new Coffee();
Coffee = new MilkCoffee(Coffee);

Console.WriteLine($" Milk Coffee Cost : {Coffee.getCost()}");
Coffee.printDescription();