


// struct is not inherit
// struct is same like class 
//struct is sealed
// struct is a value type
// struct is use for small group
// it give space on stack
// it check value Equality

Customer obj = new Customer();
obj.firstName = "Ajay";
obj.lastName = "Bhosle";

obj.print();
Customer obj1= new Customer("Vivek" , "Ingale");
obj1.print();


Customer obj2 = obj1;
obj2.print();

obj2.firstName = "Abhi";
obj2.print();
obj1.print();


Customer obj4 = new Customer("Abhi", "Ingale");

if (obj2.Equals(obj4))
{

    Console.WriteLine("Equal");
}
else {

    Console.WriteLine("Not Equal");
}

Console.ReadLine();