
//string methods

#region ToCharArray
string str = "Ajay Bhosle";

string str1 = new string("Ajay Bhosle");

if (str == str1)
{
    Console.WriteLine("Equal"); //Equal
}


char[] str2 = str1.ToCharArray();

for (int i = 0; i < str2.Length; i++)
{
    Console.Write($"{str2[i]} ");
}
Console.WriteLine();


foreach(char ch in str2)
{
    Console.Write($"{ch} ");
}

Console.WriteLine();

#endregion

#region ToUpper()

String name1 = "Anjali Bhosle";
Console.WriteLine(name1.ToUpper());

// without using method

char[] arr1 = name1.ToCharArray();

for (int i = 0; i < arr1.Length; i++) {

    if (arr1[i] >= 97 && arr1[i] <= 122)
    {
        arr1[i] = (char)(arr1[i]-32);
    }
}

string str4 = new string(arr1);

Console.WriteLine(str4);
#endregion

