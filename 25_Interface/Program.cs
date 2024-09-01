
Batch obj = new Batch();
obj.BatchTime();
obj.printFees();

Fees obj3 = new Batch();
obj3.printFees();

IBatch23 obj1 = new Batch();
obj1.BatchTime();

Console.WriteLine(IBatch23.x);


ICustomer obj4 = new SilverCustomer();
obj4.CollectFood();
obj4.PrintTicket();

ICustomer obj5 = new PlatinumCustomer();
obj5.CollectFood();
obj5.PrintTicket();


