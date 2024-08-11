
#region 1.Write a Program for Coffee shop display menu to user
/*
Console.WriteLine("******************** (: Welcome Coffee Shop :) *************************");

int SmallQuantity = 0, MediumQuantity = 0, LargeQuantity = 0;
string str = "";
do
{
    Console.WriteLine("\n***** MENU *****");
    Console.WriteLine("What u want today ? ");
    Console.WriteLine("1.SmallCoffee     10/- \n2.MediumCoffee    20/-\n3.LargeCoffee     30/-");

    Console.WriteLine("\nWhich Coffee u want?");

    int order = Convert.ToInt32(Console.ReadLine());

    switch (order)
    {

        case 1:
            Console.WriteLine("You Choose Small Coffee");
            Console.WriteLine("How Much quantity u want?");
            SmallQuantity += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You Ordered {SmallQuantity} SmallCoffee");
            break;

        case 2:
            Console.WriteLine("You Choose Medium Coffee");
            Console.WriteLine("How Much quantity u want?");
            MediumQuantity += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You Ordered {MediumQuantity} Medium Coffee");
            break;

        case 3:
            Console.WriteLine("You Choose Large Coffee");
            Console.WriteLine("How Much quantity u want?");
            LargeQuantity += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You Ordered {LargeQuantity} Large Coffee");
            break;
        default:
            Console.WriteLine("Invalid Order? plz check once again");
            break;
    }

    Console.WriteLine("Do u want to order once again? plz anser in 'yes' or 'no'");
    str = Console.ReadLine().ToUpper();

} while (str=="Y" || str=="Yes");

Console.WriteLine("\n\n");

Console.WriteLine("************ Total Bill **************");

if (SmallQuantity < 0 || MediumQuantity < 0 || LargeQuantity < 0) {

    Console.WriteLine("\nThanks For Visisng...  :)");
}

if (SmallQuantity > 0) {

    Console.WriteLine($"SmallCofee =   {SmallQuantity} * 10 = {SmallQuantity*=10} ");

}


if (MediumQuantity > 0)
{

    Console.WriteLine($"MediumCofee =   {MediumQuantity} * 20 = {MediumQuantity *= 20} ");

}

if (LargeQuantity > 0)
{

    Console.WriteLine($"LargeCofee =   {LargeQuantity} * 30 = {LargeQuantity *= 30}");

}

Console.WriteLine($"\nTotal Bill Amount = {SmallQuantity+MediumQuantity+LargeQuantity}/-");

Console.WriteLine("\n*********** Thank You Visit Again...! :) ************");

*/
#endregion

#region 2.Write a program to check Input is Prime or not
/*
Console.WriteLine("Check Number is Prime or Not");
string str = "";
do
{

    Console.WriteLine("\nPlz enter number: ");

    int num = Convert.ToInt32(Console.ReadLine());
    int count = 0;

    for (int i = 1; i <= num/2; i++) {

        if (num % i == 0) { 
            
            count++;
        }
    }
    if (count == 1 && num != 1)
    {

        Console.WriteLine($"{num} is a Prime NUmber ");
    }
    else {

        Console.WriteLine($"{num} is Not a Prime NUmber ");
    }

    Console.WriteLine("\nDo u want to check any NUmber plz enter 'Yes' otherwise 'No' ?");
    str=Console.ReadLine().ToUpper();

} while (str=="Y" || str =="Yes");
*/

#endregion

#region 3.Write a program for Print All Prime NUmbers till Target
/*

Console.WriteLine("Print All Prime NUmbers till Target");
string str = "";
do
{

    Console.WriteLine("\nPlz enter number Target Number: ");

    int num = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nPrime Numbers till target Number: \n");
    for (int i = 1; i <= num; i++)
    {
        int count = 0;
        for (int j = 1; j <= i; j++)
        {
            if (i % j == 0)
            {

                count++;
            }
        }
        if (count == 2 && num != 1)
        {

            Console.Write($"{i} ");

        }
    }
    Console.WriteLine("\n\nDo u want to any target NUmber to print prime number plz enter 'Yes' otherwise 'No' ?");
    str = Console.ReadLine().ToUpper();

} while (str == "Y" || str == "Yes");*/
#endregion

#region 4.Write a Program to print fibonacci series
/*
Console.WriteLine("Print fibonacci series");
string str = "";
do
{
    Console.WriteLine("\nHow many numbers u want print Fibonaci series: ");

    int num = Convert.ToInt32(Console.ReadLine());
    int a = 0, b = 1;

    if (num >= 2) 
    {
        Console.Write($"{a} {b} ");

    }
    else if (num != 0 && num >= 1) {

        Console.Write($"\n{a} ");
    }

    for (int i = 2; i < num; i++) {

        int c = a + b;
        Console.Write($"{c} ");
        a = b;
        b = c;
       
    }
    
    Console.WriteLine("\n\nDo u want again prints Fibonaci series: plz enter 'Yes' otherwise 'No' ?");
    str = Console.ReadLine().ToUpper();

} while (str == "Y" || str == "Yes");*/

#endregion

#region 5.Write a program to find string is palindrome
/*

Console.WriteLine("Check string is palindrome or Not");
string str = "";
do
{

    Console.WriteLine("\nPlz enter string: ");

    string name = Console.ReadLine().ToLower();
    

    char[] arr = name.ToCharArray();
    int start=0, end=arr.Length-1;

    string temp = palindrome(arr);
    if (name.Equals(temp))
    {

        Console.WriteLine($"\n{name} is a Palindrome String");
    }

    string palindrome(char[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            char c = arr[start];
            arr[start] = arr[end];
            arr[end] = c;
            start++;
            end--;
        }
        return  new string(arr);
   
    }


    Console.WriteLine("\nDo u want to check any NUmber plz enter 'Yes' otherwise 'No' ?");
    str = Console.ReadLine().ToUpper();

} while (str == "Y" || str == "Yes");*/
#endregion

#region 6.Write a Program to find number is Armstrong or not
/*
//Sum of Cube of its digits like 153 number & 1634 also Armstrong

Console.WriteLine("Check Number is Armstrong or not");
string str = "";
do
{

    Console.WriteLine("\nPlz enter number: ");

    int num = Convert.ToInt32(Console.ReadLine());
    int temp = num;
    int sum = 0;
    bool result = Armstrong(num);

    if (result == true) {

        Console.WriteLine($"\n{num} is a Armstrong Number");
    }
    else
    {

        Console.WriteLine($"\n{num} is not a Armstrong Number");
    }
    
    // Method called
    bool Armstrong(int num) {

        if (num == 0) {
            return true;
        }
        string str = num.ToString();
        
        while (num!=0) {

            int rem = num % 10;
            
            int length = str.Length;
            int prod=1;
            //Console.WriteLine($"Length is : {length}");

            while (length!=0) {

                prod*=rem;
                length--;
            }
            sum += prod;
            num /= 10;

        }
        //Console.WriteLine($"sum is : {sum}");
        if (sum == temp)
        {
            return true;
        }
        return false;
    }
    Console.WriteLine("\nDo u want to check any NUmber plz enter 'Yes' otherwise 'No' ?");
    str = Console.ReadLine().ToUpper();

} while (str == "Y" || str == "Yes");
*/
#endregion

#region 7.Write a program to print Reverse String without in-built method
/*
Console.WriteLine("to print Reverse String without in-built method");
string str = "";
do
{

    Console.WriteLine("\nPlz enter String: ");

    string str1 = Console.ReadLine();

    char[] arr = str.ToCharArray();

    string revers = reverse(str1);

    Console.WriteLine($"Original String : {str1}");
    Console.WriteLine($"Reverse String: {revers}");   

    string reverse(string str)
    {

        char[] arr = str.ToCharArray();
        int start = 0, end = arr.Length - 1;

        while (start < end)
        {

            char temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }*//*
        string str2 = arr.ToString();
        Console.WriteLine($"hiiii {str2}");*//*
        return new string(arr);
    }

    Console.WriteLine("\nDo u want to reverse any string  plz enter 'Yes' otherwise 'No' ?");
    str = Console.ReadLine().ToUpper();

} while (str == "Y" || str == "Yes");*/

#endregion

#region 8.Write a program to reverse given Array
/*

Console.WriteLine("to reverse given Array");
string str = "";
do
{

    Console.WriteLine("\nPlz enter Array Size: ");

    int size = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nPlz enter Array Elements: ");
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i]=Convert.ToInt32(Console.ReadLine());

    }
    Console.WriteLine();
    Console.WriteLine("Original Array is: ");

    foreach (int arr1 in arr) {

        Console.Write($"{arr1} ");
    }


    reverse(arr);

    Console.WriteLine("\nReverse array is: ");
    foreach (int arr1 in arr)
    {

        Console.Write($"{arr1} ");
    }
    Console.WriteLine();


    void reverse(int[] arr)           //method called
    {

        int start = 0, end = arr.Length - 1;

        while (start < end)
        {

            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }

    Console.WriteLine("\nDo u want to reverse any array plz enter 'Yes' otherwise 'No' ?");
    str = Console.ReadLine().ToUpper();

} while (str == "Y" || str == "Yes");*/


#endregion