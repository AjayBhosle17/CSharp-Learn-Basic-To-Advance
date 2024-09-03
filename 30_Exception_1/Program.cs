
#region Exception Handle
/*Calculator calculator = new Calculator();
calculator.division(10, 2);
calculator.division(10, 3);

try
{
    Console.WriteLine("plz enter numerator");
    int numerator = int.Parse(Console.ReadLine());

    Console.WriteLine("plz enter denominator");
    int denominator = int.Parse(Console.ReadLine());

    calculator.division(numerator, denominator);
}
catch (FormatException ex)
{

    Console.WriteLine($"Message name : {ex.Message}");
    Console.WriteLine($"Type name : {ex.GetType().Name}");

}

catch (OverflowException ex)
{
    Console.WriteLine($"Message name : {ex.Message}");
    Console.WriteLine($"Type name : {ex.GetType().Name}");
}
catch (Exception ex) {

    Console.WriteLine($"Message name : {ex.Message}");
    Console.WriteLine($"Type name : {ex.GetType().Name}");
}*/

#endregion

/*

Calculator calculator =new Calculator();
Console.WriteLine("Enter NUmerator");
try
{
    int a;
    if (int.TryParse(Console.ReadLine(), out a))
    {

        Console.WriteLine("Enter Denominator");
        int b;
        if (int.TryParse(Console.ReadLine(), out b))
        {

            calculator.division(a, b);
        }
        else {

            Console.WriteLine("Plz Enter Correct Denominator");
        }
       

    }
    else {

        Console.WriteLine("Plz Enter Correct Numerator");
    }

}
catch (Exception ex) {
    Console.WriteLine("Outer Catch Block");
    Console.WriteLine($"Message name : {ex.Message}");
    Console.WriteLine($"Type name : {ex.GetType().Name}");
    Console.WriteLine($"stack {ex.StackTrace}");
}

*/

#region Finally
/*
Calculator calculator = new Calculator();

Console.WriteLine("Plz Enter 2 numbers: ");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

try
{
    calculator.Division(num1, num2);
}
catch(Exception obj) {

    Console.WriteLine("Outer Block");
}
*/
#endregion
/*

Calculator calculator = new Calculator();

Console.WriteLine("Plz Enter 2 numbers: ");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
//int result = calculator.Division(num1, num2);
//Console.WriteLine($"result: {result}");

try
{
    int result = calculator.Division(num1, num2);
    Console.WriteLine($"result: {result}");
}
catch (Exception e)
{

    Console.WriteLine("Outer Block");


    Console.WriteLine($"Message name : {e.Message}");
    Console.WriteLine($"Type name : {e.GetType().Name}");
}

Console.ReadLine();*/



try
{
    Calculator obj = new Calculator();
    string str = obj.getName();

    Console.WriteLine(str);
}
catch (myCustomException obj) {

    Console.WriteLine($"my Exception name: {obj.Message}");

} 




Console.ReadLine();