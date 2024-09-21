Console.WriteLine("*******   Welcome to Calculator App   *******");

string choice = "";
do
{
    Console.WriteLine("Please enter first number");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please enter second number");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please enter operation to perform");
    string op = Console.ReadLine();

    switch (op)
    {
        case "+":
            Console.WriteLine($"Addition : {num1} + {num2} = {num1 + num2}");
            break;
        case "-":
            Console.WriteLine($"Substraction : {num1} - {num2} = {num1 - num2}");
            break;
        case "*":
            Console.WriteLine($"Multiplication : {num1} * {num2} = {num1 * num2}");
            break;
        case "/":
            Console.WriteLine($"Division : {num1} / {num2} = {num1 / num2}");
            break;
        default:
            Console.WriteLine($"Invalid operation, Please choose Correct Operator +, -, *, /");
            break;
    }

    Console.WriteLine("Do you want to continue?");
    choice = Console.ReadLine().ToUpper();

} while (choice == "YES" || choice == "Y");

Console.ReadLine();



