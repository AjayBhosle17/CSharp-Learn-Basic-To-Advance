
// Object Type
#region Type Gettype typeof
/*using myclasses;
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

Type y2=x1.GetType();

Type y3=typeof(Type);

Type type3 = x1.GetType();

Console.WriteLine($"{type3.Name}");

Console.WriteLine(y3.Name);*/


#endregion



#region tostring()
/*
using myclasses;

int i = 10;
int j = 20;

Console.WriteLine($"i+j = {i.ToString() + j.ToString()}");

Customer customer = new Customer() { firstName = "Ajay" , lastName="Bhosle"};
Console.WriteLine(customer.ToString());
//Customer customer1 = new Customer() {firstName = "A" }
*/
#endregion


#region equal
using myclasses;

int i = 10;
int j = 10;

if (i.Equals(j))
{

    Console.WriteLine("Equal");
}
else {

    Console.WriteLine("NOt equal");
}


string s1 = "Ajay";
string s2 = "Ajay";

if (s1.Equals(s2)) {

    Console.WriteLine("Equal");
}
else
{

    Console.WriteLine("Not Equal");

}

Customer obj1 = new Customer() { firstName="Ajay", lastName="Bhosle" };
Customer obj2 = new Customer() { firstName = "Vijay", lastName = "Bhosle" };

if (obj1.Equals(obj2))
{

    Console.WriteLine("Equal");
}
else {

    Console.WriteLine("Not Equal");
}


#endregion
string a1 = "Ajay";
string a2 = "Bhosle";
string a3 = "Ajay";

Console.WriteLine(a1.GetHashCode());
Console.WriteLine(a2.GetHashCode());
Console.WriteLine(a3.GetHashCode());
Console.WriteLine(obj1.GetHashCode());
Console.WriteLine(obj2.GetHashCode());

Console.ReadLine();

