// String function

// 1) Length

string name = "Ajay Bhosle";
Console.WriteLine($"Name is = {name}");
Console.WriteLine($"Length of {name} is = {name.Length}");
Console.WriteLine("\n");

// 2) ToUpper

Console.WriteLine($"Name is = {name}");
Console.WriteLine($"Uppercase: {name.ToUpper()}");
Console.WriteLine("\n");


// 3) ToLower
Console.WriteLine($"Name is = {name}");
Console.WriteLine($"Lowercase: {name.ToLower()}");
Console.WriteLine("\n");

// 4) Trim

String name1 = "  Ajay  Bhosle   ";

Console.WriteLine($"Name is = {name1}");
Console.WriteLine($"Trim Start with= {name1.TrimStart()}");


Console.WriteLine($"Name is = {name1}");
Console.WriteLine($"Trim end with= {name1.TrimEnd()}");


Console.WriteLine($"Name is = {name1}");
Console.WriteLine($"Trim Both Side = {name1.Trim()}");


String name2 = "Ajay, Bhosle ,";

Console.WriteLine($"Name is = {name2}");
Console.WriteLine($"Trim End Side (,) = {name2.TrimEnd(',')}");
Console.WriteLine("\n");



// Escape Sequence

// String name4 = ""Ajay Bhosle"";  //  error

String name5 = "\"Ajay Bhosle\"";
Console.WriteLine($"Name is = {name5}");
Console.WriteLine("\n");


name5 = "'Ajay Bhosle'";

Console.WriteLine($"Name is with Single Quote = {name5}");
Console.WriteLine("\n");

String path = "C:\\Ajay\\C#";

Console.WriteLine($"path is = {path}");
Console.WriteLine("\n");


// @

path = @"C:\Ajay\C#";

Console.WriteLine($"path is  use of @ = {path}");
Console.WriteLine("\n");
