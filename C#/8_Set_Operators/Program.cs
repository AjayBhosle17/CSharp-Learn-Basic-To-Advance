// Set Operators

//1.Distinct
//2.Except
//3.Intersect
//4.Union

Console.WriteLine("Distinct: ");
List<int> ls= new List<int>() { 10,20,30,40,50,20};

IEnumerable<int> obj=ls.Distinct();

foreach (int item in obj) { 

    Console.WriteLine(item);
}

Console.WriteLine("\nUnion: ");

List<int> ls1 = new List<int>() { 20, 40, 70 };

IEnumerable<int> obj1=ls.Union(ls1);

foreach (int item in obj1)
{
    Console.WriteLine(item);

}

Console.WriteLine("\nIntersect: ");

obj1 = ls.Intersect(ls1);

foreach (int item in obj1) { 

    Console.WriteLine(item);
}

Console.WriteLine("\nExcept");

obj1= ls.Except(ls1);

foreach (int item in obj1) { 

    Console.WriteLine(item);
}


//Concat

Console.WriteLine("\nConcat");
obj1 = ls.Concat(ls1);


foreach (int item in obj1) { 

    Console.WriteLine(item);
}


// Iequality
//sequenceEqual

List<int> ls3 = new List<int>() { 10,20,30};
List<int> ls4 = new List<int> { 20,10,30};

ls3.Sort();
ls4.Sort();

bool result = ls3.SequenceEqual(ls4);
Console.WriteLine(result);

List<String> ls5 = new List<string>() { "Ajay","Bhosle"};
List<String> ls6 = new List<string>() { "Ajay", "Bhosle" };


result =ls5.SequenceEqual(ls6);
Console.WriteLine(result);

