// Statements
/*
1. if 
2. if else
3. if (ladder)
4. if else if else
5. Switch */

Console.WriteLine("If Statement data\n");
Console.WriteLine("Enter The Number");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 5)
{
    Console.WriteLine($"num {num} is = {5}");
}

Console.WriteLine("\n");

// if -else

Console.WriteLine("If else Statement data\n");

Console.WriteLine("Enter your Age");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 >= 18)
{

    Console.WriteLine("Eligible for Voating");

}
else
{

    Console.WriteLine("not Eligible for Voating beacause ur age is less than 18");
}

Console.WriteLine("\n");

// if ladder

// print 3 if num is divisble by 3  , print 5 if num is divisible by 5

Console.WriteLine("ladder If Statement data\n");
Console.WriteLine("Enter Number");

int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"You Entered {y1} number");

if (num % 3 == 0)
{

    Console.WriteLine($"num {num} is Divisible by 3");
}


if (num % 5 == 0)
{

    Console.WriteLine($"num {num} is Divisible by 5");
}

Console.WriteLine("\n");

// if else if else


Console.WriteLine("If else if else Statement data\n");

// Find Highest Number in 2 numbers

Console.WriteLine("Enter First Number");
int num4 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Enter Second Number");
int num5 = Convert.ToInt32(Console.ReadLine());


if (num4 > num5)
{

    Console.WriteLine($"{num4} is greter");

}
else if (num4 < num5)
{

    Console.WriteLine($"{num5} is greter");
}
else
{
    Console.WriteLine($"Both  are Equal");
}
Console.WriteLine("\n");

// Switch

Console.WriteLine("Switch Data");

char ch = 'B';

switch (ch)
{

    case 'A':
        Console.WriteLine("Case is match 'A' = A ");
        break;


    case 'B':
        Console.WriteLine("Case is match 'B' = B ");
        break;


    case 'C':
        Console.WriteLine("Case is match 'C' = C ");
        break;

    default:
        Console.WriteLine("Case is not match");
        break;

}



