
// Nullable Type

int num = 10;

Console.WriteLine(num);

// int num1 = null; // Basically by default value of any variable  or datatype is not null.

int? num1 = null;

Console.WriteLine(num1);

int num2 = 20;  // it is a basically non - nullable type

num = num2;
Console.WriteLine($"Current Value of num is : {num}");

Object obj = ++num; // value type to reference type

Console.WriteLine($"Current Value of obj is : {obj}");

int? num3 = 1200;
Console.WriteLine(num3);

int num4 = num3 ?? 0;
Console.WriteLine(num4);

/*String str = null;

Console.WriteLine(str.ToUpper());  // NullReferenceException
*/

int num6 = (int)obj; // refernce type to value type => Unboxing
Console.WriteLine(num6);

float num7 = 18.5f;

int num8 = (int)num7;
Console.WriteLine(num8);

