
//A.fun();

// Customer obj = new Customer(); // abstract class does not create object

Console.WriteLine("\nSilverCustomer object Created");
SilvCustomer obj = new SilvCustomer();
obj.showTiming();
obj.printTicket();
obj.showCurrentTime();


Console.WriteLine("\nGoldCustomer object Created");
GoldCustomer obj1 = new GoldCustomer();
obj1.showTiming();
obj1.printTicket();
obj1.showCurrentTime();


Console.WriteLine("\nCustomer Reference  Created");
Customer obj2 = new SilvCustomer();
obj2.showTiming();
obj2.printTicket();
obj2.showCurrentTime();


Console.WriteLine("\nMethod Hiding achieve here beacuse not override");
GoldCustomer obj3 = new Platinum();
obj3.printTicket();