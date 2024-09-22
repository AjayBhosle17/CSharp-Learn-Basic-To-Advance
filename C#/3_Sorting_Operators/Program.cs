
// Sorting 

Console.WriteLine("Reverse: ");
List<int> list = new List<int> {1,2,3,3,2,1,2};
list.Reverse();

Console.WriteLine("Reverse: List<int> { 1, 2, 3, 1, 2, 3 } \n");
foreach (var item in list) { 

    Console.WriteLine(item);
}
Console.WriteLine("\nOrderby\n");

var list2 = list.OrderBy(x => x % 2 != 0);

foreach (var item in list2)
{
    Console.WriteLine(item);
}

Console.WriteLine("Reverse Student List: ");
List<Student> list1 = Student.getAll();
list1.Reverse();

foreach (var item in list1)
{

    Console.WriteLine($"RollNO: {item.RollNo}\t Name: {item.Name}\t Age: {item.Age} ");
}

Console.WriteLine("\nOrdered By Age");
IOrderedEnumerable<Student> data=list1.OrderBy(s=>s.Age);
foreach (var item in data)
{
    Console.WriteLine($"RollNO: {item.RollNo}\t Name: {item.Name}\t Age: {item.Age} ");

}

Console.WriteLine();



//bool result = list.All(i => i % 2 == 0);
//Console.WriteLine(result);

//result = list.Any(i => i % 2 == 0);
//Console.WriteLine(result);


//result = list.Contains(1);
//Console.WriteLine(result);
