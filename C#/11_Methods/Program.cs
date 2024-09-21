
#region Method
//bool Prime(int num) {

//    int count = 0;

//    for (int i = 1; i <= num; i++) {

//        if (num % i == 0) { 
        
//        count++; 
//        }
//    }
//    if (count ==2) { 
    
//        return true;
//    }
    
//    return false;
//}

//Console.WriteLine("Plz enter a Integer Number");
//int num = Convert.ToInt32(Console.ReadLine());
//bool ans = Prime(num);

//if (ans == true)
//{
//    Console.WriteLine($"{num} is a prime number");
//}
//else {
//    Console.WriteLine($"{num} is not a prime number");
//}

//Prime(num);



#endregion Method

#region Example1
/*
//string ajay()
//{
//    return "Ajju";
//}

//string a =ajay();
//Console.WriteLine(a);

void ajju(int num )
{
     

    switch (num)
    {
        case 1:
            Console.WriteLine($"{num} : is january");
            break;
        case 2:
            Console.WriteLine($"{num} : is feburary");
            break;
        case 3:
            Console.WriteLine($"{num} : is March");
            break;
        case 4:
            Console.WriteLine($"{num} : is April");
            break;
        case 5:
            Console.WriteLine($"{num} : is May");
            break;
        case 6:
            Console.WriteLine($"{num} : is June");
            break;
        case 7:
            Console.WriteLine($"{num} : is july");
            break;
        case 8:
            Console.WriteLine($"{num} : is August");
            break;
        case 9:
            Console.WriteLine($"{num} : is September");
            break;
        case 10:
            Console.WriteLine($"{num} : is October");
            break;
        case 11:
            Console.WriteLine($"{num} : is November");
            break;
        case 12:
            Console.WriteLine($"{num} : is December");
            break;
    }
}
ajju(9);

*/

//Console.WriteLine("enter your number to find year of month");
//int num2 = Convert.ToInt32(Console.ReadLine());
#endregion Example1

#region Example2
/*
Console.WriteLine("Plz Enter Comma Separate Value Integer Numbers");

String All_Values = Console.ReadLine();

String[] arr = All_Values.Split(',');

int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    sum += Convert.ToInt32(arr[i]);

}
Console.WriteLine($"Total Sum: {sum}");

*/
#endregion Example2

#region Method Para 

void sum1(int x ,int y) {

    Console.WriteLine($"Ans is : {x} + {y} = {x + y} ");
}

sum1(10, 20);
//sum1(10.5, 20.5); //error
//sum1(10, 10.5f);    // error


void sum2(int x=10, int y=5)
{

    Console.WriteLine($"Ans is : {x} + {y} = {x + y} ");
}

sum2(10, 20);


// Find Numbers 1 to 10 without For Loop

int sum8(int num) {

    if (num >= 0) {

        return 0;
    }

    return num + sum8(--num); 
}
 
int num1 = 10;

int sum = sum8(num1);
Console.WriteLine($"Total_sum = {sum}");


#endregion

#region  Example Reverse String 

// Input :  ajay
// Output:  yaja

String Reverse(String str) {

    char[] arr = str.ToCharArray();

    int start=0; int end = arr.Length-1;

    while (start < end) { 
    
        char temp = arr[start];
        arr[start] = arr[end];
        arr[end] = temp;
        start++;
        end--;
    }
    return new string(arr);

}

String Name = "Ajay Bhosle";
String Str1 = Reverse(Name);

Console.WriteLine($"Original String : {Name}");
Console.WriteLine($"Reverse String : {Str1}");

Console.WriteLine();

#endregion

#region reverse the words in a sentence

// Input:  i am student 
//Output:  student am i
string Reverse1(string str) {

    string[] arr = str.Split(" ");

    int start = 0; int end = arr.Length-1;
    while (start < end)
    {

        String temp = arr[start];
        arr[start] = arr[end];
        arr[end] = temp;

        start++; end--;
    }
    string str1 =string.Join(" ", arr);
    return new string(str1);

}

String Name2 = "I am Student";
string Str2 = Reverse1(Name2);

Console.WriteLine($"Original String : {Name2}");
Console.WriteLine($"Reverse String : {Str2}");
#endregion