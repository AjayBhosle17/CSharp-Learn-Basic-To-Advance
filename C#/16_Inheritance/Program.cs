
// Inheritance
Console.WriteLine("Customer data: ");
Customer obj = new Customer();

obj.ShowTiming();

bool status = obj.isTicketAvailable();

Console.WriteLine($"{ status} Ticket is Available");


// parent-child realtion inherit methods and fields in Derived Class
Console.WriteLine("\nSilver data");

SilverCustomer obj1= new SilverCustomer();

obj1.ShowTiming();
Console.WriteLine($"Ticket Amount is = {obj1.ticketAmount}");

Console.WriteLine($"Holl No is = {obj1.hallNo}");



// parent-child realtion inherit methods of base class and fields in Derived Class
Console.WriteLine("\nGolden Customer data");

GoldenCustomer obj2 = new GoldenCustomer();

obj2.ShowTiming();
Console.WriteLine($"Ticket Amount is = {obj2.ticketAmount}");

Console.WriteLine($"Holl No is = {obj2.hallNo}");


