
using System.Reflection.Metadata;
/*
Calculator obj = new Calculator();
bool status = obj.AreEqual(10,10);

Console.WriteLine($"AreEqual(10,10) : {status}");

status = obj.AreEqual("Ajay", "Bhosle");
Console.WriteLine($"AreEqual(\"Ajay\", \"Bhosle\"):  {status}");

status= obj.AreEqual('A','O');
Console.WriteLine($"AreEqual('A','O') {status}");

// above is solve by using as a parameter object but now
 
status = obj.AreEqual(10,"Ajay");   // no type safety
Console.WriteLine($"AreEqual(10,\"Ajay\") {status}");*/

//UserStringHandle Generics

Calculator obj = new Calculator();
bool status = obj.AreEqual<string>("Ajay", "Bhosle");

Console.WriteLine($"AreEqual<string>(\"Ajay\", \"Bhosle\"): {status}");

// status = obj.AreEqual<int>(10, "Ajay"); // error

status = obj.AreEqual<int,string>(10,"Ajay");
Console.WriteLine($"AreEqual<int, string>(10, \"Ajay\")  {status} ");

;




//

Student<int,string> obj1 = new Student<int ,string>();
obj1.Add<int>(10, 10);


//Console.WriteLine($"AreEqual<int, bool>(10, 10) {status1}")



