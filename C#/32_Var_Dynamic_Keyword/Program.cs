#region var keyword
/*
var v1 = 10;
var v2 = 11.4f;
var v3 = "Ajay Bhosle";
var v4 = new int[5];
var v5 = new object();

var v6 = new Customer();

v6.print();

//var a; // error


*//*string str = "123";
int b;

bool x = int.TryParse(str, out b);
if (x) {

    Console.WriteLine(++b);
}*/
/*
string str=null;

Console.WriteLine(str.ToLower());*//*


var v7 = new Customer() { firstName = "Ajay", lastName = "Bhosle" };
Console.WriteLine(v7.GetType().Name);
Console.WriteLine(v7.lastName);
var v8 = new { firstName = "Ajay", lastName = "Bhosle" };
Console.WriteLine($"Customer: {v8.GetType().Name}");

Console.WriteLine(v8.firstName);

*/
#endregion

#region Dynamic keyword

// if runtime change type main advantages

dynamic d1 = 10;
d1 = "Ajay";


/*
var a = 20;
a = "Ajay";*/

Console.WriteLine(d1);

dynamic d3 = new int[5];
dynamic d4 = new Customer();
d4.print();
//d4.printA(); // error

dynamic d5 = new { firstName = "Ajay" ,lastName = "Bhosle"};
Console.WriteLine(d5.firstName);

#endregion

Console.ReadLine();