/*

Address obj = new Address("near zp School Kumbephal","Ambajogai");

Person obj1 = new Person("Ajay",obj);

obj.ShowDetails();
obj1.ShowDetails();*/


// Conversion

int[] arr = {10,20,30,40,50 };

List<int> list = arr.ToList();

Console.WriteLine("int[] arr = {10,20,30,40,50 }; array convert in list: ");
foreach (int i in list) { 

    Console.Write($"{i} \t");
}

Console.WriteLine("\nArray Convert in string");

string str =string.Join(", ", arr);
Console.WriteLine(str);

Console.WriteLine("\nlist to Dictionary: ");
Dictionary<int,int> dict = list.ToDictionary(x=>x,y=>y);

foreach (KeyValuePair<int,int> i in dict)
{

    Console.Write($"Key= {i.Key}  Value:{i.Value} \t");
}

