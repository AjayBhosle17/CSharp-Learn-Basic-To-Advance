/*

#region Generic Delegate

//public delegate bool Predicate<in T>(T obj);

Predicate<string> pd = delegate (string a)
{

    return a.Length > 0;
};

bool name = pd("Ajay");

Console.WriteLine(name);


Predicate<int> pd1 = delegate (int a)
{

    return true;
};

bool x = pd1(12);

Console.WriteLine(x);



Action<int, int> Ac1 = delegate (int a, int b)
{
    Console.WriteLine($"Addition is : {a + b}");
};


Action Ac2 = delegate ()
{
    Console.WriteLine("No Parameter");
};
Ac2();

Action<string, string> Ac3 = delegate (string firstName, string lastName)
{
    Console.WriteLine($"FullName: {firstName} {lastName}");
};

Ac3("Ajay", "Bhosle");


Func<string> f1 = delegate ()
{

    return "Hii Hello , Good Morning";
};

string str1 = f1();

Console.WriteLine(str1);

Predicate<int> pd123 = delegate (int a)
{

    return 10 == 0;
};
pd123(5);

// above predicate convert in func

Func<int, bool> f2 = delegate (int a)
{
    return true;
};


bool x12 = f2(10);
Console.WriteLine(x12);

Func<int, bool> f3 = (a) => true;


f3(12);


Student obj = new Student();
#endregion delegate
*/



#region Lambda Expression

//public delegate bool Predicate<in T>(T obj);

Predicate<string> pd =(a)=>a.Length > 0;

bool name = pd("Ajay");

Console.WriteLine(name);


Predicate<int> pd1 =a=>true;

bool x = pd1(12);
Console.WriteLine(x);



Action<int, int> Ac1 =(a,b)=>Console.WriteLine($"Addition is : {a + b}");
Ac1(10, 20);

Action Ac2 = () => Console.WriteLine("Ac2() Called");
Ac2();

Action<string, string> Ac3 = (firstName,lastName) => Console.WriteLine($"FullName: {firstName} {lastName}");
Ac3("Ajay","Bhosle");


Func<string> f1 = ()=> "Hii Hello , Good Morning";

string str1 = f1();

Console.WriteLine(str1);

Predicate<int> pd123 = (a)=> 10 == 0; 
pd123(5);

// above predicate convert in func

Func<int, bool> f2 = (a)=>true;

bool x12 = f2(10);
Console.WriteLine(x12);

Func<int, bool> f3 = (a) => true;


f3(12);


Student obj = new Student();


Predicate<string> pd21 = (a) => a.Length > 4;

bool result=pd21("Ajay");


Console.WriteLine(result);
#endregion 
