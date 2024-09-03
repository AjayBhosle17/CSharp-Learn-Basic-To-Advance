
// Exception Handling
#region DivideByZeroException
/*

Console.WriteLine("Plz Enter 2 numbers: ");
int num1 = int.Parse(Console.ReadLine());
int num2=int.Parse(Console.ReadLine());
Calculator obj = new Calculator();
obj.Division(num1,num2);*/
#endregion

#region Exception Handle
/*
using Divide_Zero_Exception;


Console.WriteLine("Plz Enter 2 numbers: ");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
Calculator obj = new Calculator();
obj.Division(num1, num2);
*/
#endregion


/*
Console.WriteLine("Plz Enter 2 numbers: ");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
Calculator obj = new Calculator();

try
{
    obj.Division(num1, num2);
}
catch(Exception ex)
{

    Console.WriteLine(ex.Message);

}
*/

/*
fun1();

Console.WriteLine("1.");
static void fun1() {
    Console.WriteLine("fun1 () called");
    try
    {
        fun2();
    }
    catch (Exception ex)
    {
        *//*Console.WriteLine(ex.Message);*//*
        throw ex;
    }

}
static void fun2()
{
    throw new Exception("Exception handle");
}
*/

int[] numbers = { 1, 2, 3 };
/*
try
{
    int index = 5;
    Console.WriteLine(numbers[index]); // This will throw an exception
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Caught an exception, rethrowing...");
    throw; // Rethrow the same exception
}*/

try {
    int index = 4;
    if (index >= numbers.Length) { 
    
        throw new IndexOutOfRangeException("Out of index u access element");
    }
    Console.WriteLine(numbers[index]);
}
catch (IndexOutOfRangeException ex) { 

    Console.WriteLine("Hii Hello");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.GetType().Name);
}

Console.ReadLine();



