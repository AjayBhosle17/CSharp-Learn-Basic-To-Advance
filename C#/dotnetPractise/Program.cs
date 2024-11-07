
int x = 10;

Console.WriteLine(sizeof(int));

DateTime dateTime = DateTime.Now;
Console.WriteLine(dateTime.ToString());


Console.WriteLine($"x value is : {x}");

string name = "Ajay";

Console.WriteLine(name);

name=name.ToUpper();
Console.WriteLine(name);

name = "               Ajay";
Console.WriteLine(name);

name = name.TrimStart(' ');
Console.WriteLine(name);

name = "Ajay_____________________";
Console.WriteLine(name);

name = name.TrimEnd('_');
Console.WriteLine(name);


name = "            Ajay_____________________";
Console.WriteLine(name);

name = name.Trim(' ', '_');
Console.WriteLine(name);

string path =@"D:/Coding2/V#/SQL/B24SessionNotes";
Console.WriteLine(path);

string ab = "\'ajay\'";
Console.WriteLine(ab);

ab = "\"Ajju\"";
Console.WriteLine(ab);

string name1 = "Ajju1";
Console.WriteLine(name1+ab);
Console.WriteLine(name1.Concat(ab));
