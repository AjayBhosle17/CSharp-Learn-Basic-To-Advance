
// Object Type
using myclasses;
object v1 = 10;
object v2 = 11.4f;
object v3 = "Ajay Bhosle";
object v4 = new int[5];
object v5 = new object();

object v6 = new Customer();

//v6.print();

Customer customer = new Customer();

Type type = typeof(Customer);
Console.WriteLine($"type is : {type}");
Console.WriteLine($"name is {type.Name}  and {type.Namespace}");


Customer customer1 = new Customer();

Type type1 = customer1.GetType();
Console.WriteLine($"type1 is : {type1}");
Console.WriteLine($"name is {type.Name}  and {type.Namespace}");

object x1 = 22;

Type type3 = x1.GetType();

Console.WriteLine($"{type3.Name}");
Console.ReadLine();