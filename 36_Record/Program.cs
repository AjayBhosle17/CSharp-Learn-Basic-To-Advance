/*Child obj = new Child();

obj.parent.fun();*/


Parent obj = new Parent();
obj.firstName = "Ajay";
obj.lastName = "Bhosle";

Parent obj2 = new Parent() { firstName = "Ajay" ,lastName="Bhosle"};

if (obj.Equals(obj2))
{

    Console.WriteLine("Equal");
}
else {

    Console.WriteLine("Not Equal");
}

Parent obj3 = obj2;
obj3.firstName = "Vijay";
Console.WriteLine($"obj2 firstname : {obj2.firstName}");
Console.WriteLine($"obj3 firstname : {obj3.firstName}");


obj.print();