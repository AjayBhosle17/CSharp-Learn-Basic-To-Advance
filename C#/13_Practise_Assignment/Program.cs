
#region 1.Write a Program for Coffee shop display menu to user

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

    Console.WriteLine("\nPlz enter Target Number: ");

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

#region 9.Write a program which take input from user - print Three if that number 

/*
Write a program which take input from user - print 'Three' if that number 
is divisible by 3 print 'Five' if that number is divisible by 5 print
'THREEFIVE' if that number is divisible by 3 & 5 BOTH. */

/*
Console.WriteLine("Print NUmbers till Target those are divisible by 3 & 5");
string str = "";
do
{

    Console.WriteLine("\nPlz enter Target Number: ");

    int num = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= num; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {

            Console.Write("THREEFIVE  ");

        }
        else if (i % 3 == 0)
        {

            Console.Write("THREE  ");

        }
        else if (i % 5 == 0)
        {

            Console.Write("FIVE  ");
        }
        else {

            Console.Write($"{i}  ");
        }
    }
    Console.WriteLine("\n\nDo u want to Print NUmbers till Target those are divisible by 3 & 5  plz enter 'Yes' otherwise 'No' ?");
    str = Console.ReadLine().ToUpper();

} while (str == "Y" || str == "Yes");*/

#endregion

#region 10.Write a Program to print in format like input is 4  output  1 3 2 4
/*

Console.WriteLine("print any series in first odd and then even");
string str = "";
do
{

    Console.WriteLine("\nHow many first do you want print in above format: ");

    int num = Convert.ToInt32(Console.ReadLine());
    int odd = 1, even = 2;
    for (int i = 1; i <= num; i++)
    {
        if (odd<=num)
        {
            Console.Write(odd + " ");
            odd += 2;
        }
        else if(even<=num)
        {
            Console.Write(even + " ");
            even += 2;
        }
    

}



    Console.WriteLine("\nDo u want to continue to print series in odd even plz enter 'Yes' otherwise 'No' ?");
    str = Console.ReadLine().ToUpper(); 

} while (str == "Y" || str == "Yes");*/

#endregion

#region 11.Write a Program sort an array using bubble sort.
/*
Console.WriteLine("sort an array using bubble sort.");
string str = "";
do
{
    Console.WriteLine("\nPlz enter Array Size: ");

    int size = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nPlz enter Array Elements: ");
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());

    }
    Console.WriteLine();
    Console.WriteLine("Original Array is: ");

    foreach (int arr1 in arr)
    {

        Console.Write($"{arr1} ");
    }
    Console.WriteLine();
    Console.WriteLine("\nUsing Bubble Sort Elements are: ");

    for (int i = 0; i < arr.Length; i++) {

        for (int j = 0; j < arr.Length - i -1; j++) {

            if (arr[j] > arr[j + 1]) { 
            
                int temp = arr[j]; 
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }

        }
    }

    foreach (int i in arr) {

        Console.Write($"{i} ");
    }
    Console.WriteLine() ;

    Console.WriteLine("\nDo u want to check any NUmber plz enter 'Yes' otherwise 'No' ?");
    str=Console.ReadLine().ToUpper();

} while (str=="Y" || str =="Yes");*/

#endregion

#region 12.Swap Two Numbers Using 3rd variable
/*

Console.WriteLine("Swap Two Numbers Using 3rd variable");
string str = "";
do
{

    Console.WriteLine("\nPlz enter number 1: ");

    int a=Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nPlz enter number 2: ");
    int b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"\nBefore Swapping \na = {a} & b = {b}");

    int temp = a;
    a = b;
    b = temp;
    Console.WriteLine("\nAfter Swapping");
    Console.WriteLine($"a = {a} & b = {b}");

    Console.WriteLine("\nDo u want to swap any NUmbers plz enter 'Yes' otherwise 'No' ?");
    str = Console.ReadLine().ToUpper();

} while (str == "Y" || str == "Yes");

*/
#endregion

#region 13.Swap Two Numbers Without Using 3rd variable

/*
Console.WriteLine("Swap Two Numbers Without Using 3rd variable");
string str = "";
do
{

    Console.WriteLine("\nPlz enter number 1: ");

    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nPlz enter number 2: ");
    int b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"\nBefore Swapping \na = {a} & b = {b}");

    a = a + b;
    b = a-b;
    a = a - b;
    Console.WriteLine("\nAfter Swapping");
    Console.WriteLine($"a = {a} & b = {b}");

    Console.WriteLine("\nDo u want to swap any NUmbers plz enter 'Yes' otherwise 'No' ?");
    str = Console.ReadLine().ToUpper();

} while (str == "Y" || str == "Yes");*/


#endregion

#region 14.Print Fibonacci series using recursion
/*
Console.WriteLine("Print fibonacci series using recursion");
string str = "";
do
{
    Console.WriteLine("\nHow many numbers u want print Fibonaci series: ");

    int num = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Fibonacci Series is : \n");

    for (int i = 0; i <num; i++)
    {
        Console.Write($"{fibonacci(i)} ");
    }

    int fibonacci(int num) {

        if (num <= 1) {

            return num;
        }
        return fibonacci(num-1)+ fibonacci(num-2);
    }
    Console.WriteLine("\n\nDo u want again prints Fibonaci series: plz enter 'Yes' otherwise 'No' ?");
    str = Console.ReadLine().ToUpper();

} while (str == "Y" || str == "Yes");*/

#endregion

#region 15.Write a program to find Highest NUmber in the Array
/*

Console.WriteLine("to find Highest NUmber in the Array");
string str = "";
do
{

    Console.WriteLine("\nPlz enter Array Size: ");

    int size = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nPlz enter Array Elements: ");
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());

    }
    Console.WriteLine();
    Console.WriteLine("Original Array is: ");

    foreach (int arr1 in arr)
    {

        Console.Write($"{arr1} ");
    }
    Console.WriteLine() ;   
    int max = maximum(arr);

    Console.WriteLine($"\nMax Element in the array is : {max}") ;

    int maximum(int[] arr)
    {
        int max1 = int.MinValue;

        for (int i = 0; i < arr.Length; i++) {

            if (arr[i] > max1) { 
            
                max1= arr[i];
            }
        }
        return max1;
    }



    Console.WriteLine("\nDo u want Continue to find max NUmber in array plz enter 'Yes' otherwise 'No' ?");
    str = Console.ReadLine().ToUpper();

} while (str == "Y" || str == "Yes");*/
#endregion

#region 16.Write a program to find Second Highest NUmber in the Array

/*
Console.WriteLine("to find Second Highest NUmber in the Array");
string str = "";
do
{

    Console.WriteLine("\nPlz enter Array Size: ");

    int size = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nPlz enter Array Elements: ");
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());

    }
    Console.WriteLine();
    Console.WriteLine("Original Array is: ");

    foreach (int arr1 in arr)
    {

        Console.Write($"{arr1} ");
    }
    Console.WriteLine();

    if (arr.Length < 2) {

        Console.WriteLine("Invalid Size of Array there was not second max number");
    }
    int secondmax = max2(arr);

    Console.WriteLine($"\nSecond Max Element in the array is : {secondmax}");

    int max2(int[] arr)
    {
        int max1 = int.MinValue;
        int max2 = int.MinValue;
       
        for (int i = 0; i < arr.Length; i++)
        {

            if (arr[i] > max1)
            {
                max2 = max1;
                max1 = arr[i];

            }else if (max1 != max2 && max2 < arr[i] ) {

                max2 = arr[i];
            }
        }
        return max2;
    }



    Console.WriteLine("\nDo u want Continue to find Second max NUmber in array plz enter 'Yes' otherwise 'No' ?");
    str = Console.ReadLine().ToUpper();

} while (str == "Y" || str == "Yes");*/
#endregion

#region 17.Write a Program to find Pairs From array whose sum is equal to 30
/*

Console.WriteLine("to find  Pairs From array whose sum is equal to 30");
string str = "";
do
{

    Console.WriteLine("\nPlz enter Array Size: ");

    int size = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nPlz enter Array Elements: ");
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());

    }
    Console.WriteLine();
    Console.WriteLine("Original Array is: ");

    foreach (int arr1 in arr)
    {

        Console.Write($"{arr1} ");
    }
    Console.WriteLine();

    // to find pairs
    int[] arr2 = pairs(arr);

    if (arr2[0] != -1)
    {

        Console.WriteLine($"Pairs are the : {arr[0]} & {arr[1]} ");

    }
    else {

        Console.WriteLine("In this given array no any pair");
    }

    int[] pairs(int[] arr)
    {

        for (int i = 0; i < size; i++)
        {

            for (int j = i + 1; j < size; j++)
            {

                if (arr[i] + arr[j] == 30)
                {

                    return new int[] { arr[i], arr[j] };
                }
            }
            
        }
        return new int[] { -1 };
    }




    Console.WriteLine("\nDo u want Continue to find pairs in array whose sum is equal to 30 plz enter 'Yes' otherwise 'No' ?");
    str = Console.ReadLine().ToUpper();

} while (str == "Y" || str == "Yes");

*/
#endregion