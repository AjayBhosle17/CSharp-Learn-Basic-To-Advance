/*
int x = 10;

Console.WriteLine(sizeof(int));

DateTime dateTime = DateTime.Now;
Console.WriteLine(dateTime.ToString());


Console.WriteLine($"x value is : {x}");

string name = "Ajay";

Console.WriteLine(name);

name=name.ToUpper();
Console.WriteLine(name);

name = "               Ajay";
Console.WriteLine(name);

name = name.TrimStart(' ');
Console.WriteLine(name);

name = "Ajay_____________________";
Console.WriteLine(name);

name = name.TrimEnd('_');
Console.WriteLine(name);


name = "            Ajay_____________________";
Console.WriteLine(name);

name = name.Trim(' ', '_');
Console.WriteLine(name);

string path =@"D:/Coding2/V#/SQL/B24SessionNotes";
Console.WriteLine(path);

string ab = "\'ajay\'";
Console.WriteLine(ab);

ab = "\"Ajju\"";
Console.WriteLine(ab);

string name1 = "Ajju1";
Console.WriteLine(name1+ab);
Console.WriteLine(name1.Concat(ab));
*/
/*

int x = 10;

byte b =  (byte)x;

Console.WriteLine(b);
Console.WriteLine(b.GetType());

int val1 = int.Parse(Console.ReadLine());
Console.WriteLine(val1);


int val2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(val2);

int y;

bool val3 = int.TryParse(Console.ReadLine(), out y);

Console.WriteLine($"val3 = {val3}");

if(int.TryParse(Console.ReadLine(),out y))
{
    Console.WriteLine($"y value is : {y}");
}
else
{
    Console.WriteLine("Enter Valid NUmber");
}*/

/*
int? x = null;
Console.WriteLine(x);

 x= x??3;
Console.WriteLine(x);*/

/* Array */
/* 
int[] arr = { 10,20,30,40};

foreach (var item in arr)
{
    Console.WriteLine(item);
}*/

/* Method*/
/*
using System.Runtime.InteropServices;

void gun(int b ,int a=10 ) {

    Console.WriteLine($"Gun Method Called a= {a} b = {b}");
}

gun(10,20);



void fun([Optional] int a,int b)
{
    Console.WriteLine($"Fun Method Called a= {a} b = {b}");

}

fun(20,20);


void man(ref int a, ref int b)
{

}

int a = 20;
int b = 30;
man(ref a, ref b);


void Details(int  a , params int[] b)
{
    Console.WriteLine($"a : {a} b : ");
    foreach(int i in b) Console.WriteLine(i);
}

Details(20,[20,20,40]);*/


/* class */
/*
temp obj = new temp();
temp.gun();*/


/*Constructor*/
/*
Student obj = new Student("Ajay","Bhosle");
Student obj1 = new Student(obj);
obj1.Details();*/

/*Student obj = new Student("Ajay","Bhosle");
obj.getDetails();
Student obj2 = obj;
Student obj1 = new Student(obj);
obj1.getDetails();
obj1.firstName = "Vijay";
obj1.lastName = "Lonkar";
obj.getDetails();
obj1.getDetails();*/

/* Private Constructor*/


//Student obj = new Student();


