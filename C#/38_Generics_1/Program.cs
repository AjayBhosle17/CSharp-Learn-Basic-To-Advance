

Customer obj = new Customer();

bool status = obj.AreEqual<int>(10, 20);

Console.WriteLine(status);

bool status1 = obj.AreEqual<int, bool>(10, 10);
Console.WriteLine(status1);


status = obj.AreEqual<int, string>(10, "Ajay");
Console.WriteLine(status);



// With Class 

Student<int, string> obj1 = new Student<int, string>();
obj1.Id = 1;
obj1.Name = "Ajay Bhosle";

obj1.details();

obj1.Add<int>(10,10);

int x = obj1.Add(20,20);
Console.WriteLine(x);