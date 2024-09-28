
//Generation


Console.WriteLine("Empty: ");

List<int> list = new List<int>();

IEnumerable<int> list1 = Enumerable.Empty<int>();
Console.WriteLine(list1.Count());

Console.WriteLine("\nDefaultIfEmpty: ");

list1 = Enumerable.DefaultIfEmpty(list1);
Console.WriteLine(list1.Count());


list1= Enumerable.DefaultIfEmpty(list);

Console.WriteLine(list1.Count());
Console.WriteLine();
IEnumerable<int> result=list.Where(i => i % 2 == 0).DefaultIfEmpty(-1);

foreach (int i in result) { 

    Console.WriteLine(i);
}


Console.WriteLine("\nRepeat");

IEnumerable<int> obj1 = Enumerable.Repeat(10,5);

foreach (int item in obj1) { 

    Console.WriteLine(item);
}


Console.WriteLine("\nRange");

IEnumerable<int> in1 = Enumerable.Range(100,40);

foreach (int item in in1) { 

    Console.Write($"{item}  ");
}