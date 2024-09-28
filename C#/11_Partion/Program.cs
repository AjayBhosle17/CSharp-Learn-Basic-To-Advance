
// Partition

//take
//takeWhile
//Skip
//SkipWhile

Console.WriteLine("Take: ");
List<int>ls = new List<int>() {1,2,3,4,5,6};

IEnumerable<int> result =ls.Take(3);

foreach (var item in result) { 

   
     Console.WriteLine(item);
}

Console.WriteLine("\nTakeWhile: ");
result= ls.TakeWhile(i=>i%2!=0);

foreach (var item in result) { 

    Console.WriteLine(item);
}
Console.WriteLine();
result = ls.TakeWhile(i => i % 2 == 0);

foreach (var item in result)
{
   
    Console.WriteLine(item);
}


Console.WriteLine();
result = ls.TakeWhile(i=>i<3);

foreach (var item in result)
{

    Console.WriteLine(item);
}

Console.WriteLine("\nTakeLast");

result = ls.TakeLast(3);

foreach (int item in result)
{

    Console.WriteLine(item);
}


/*
var item1= Enumerable.Range(1, 5);
foreach (int i in item1) { 

    Console.WriteLine(i);
}*/



Console.WriteLine("\nSkip");

result = ls.Skip(3);

foreach (var item in result) { 

    Console.WriteLine(item);
}

Console.WriteLine("\nSkip_While");

result = ls.SkipWhile(i=>i%2==0);

foreach (int item in result) { 

    Console.WriteLine(item);
}

Console.WriteLine("\nSkipWhile(i => i<3)");
result = ls.SkipWhile(i => i<3);

foreach (int item in result)
{

    Console.WriteLine(item);
}


Console.WriteLine("\nSkipLast last 3 items");

result = ls.SkipLast(3);

foreach (int item in result) {

    Console.WriteLine(item);
}


