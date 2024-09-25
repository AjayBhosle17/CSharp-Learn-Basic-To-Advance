
// Sorting 
/*
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

//OrderByDecending

Console.WriteLine("\nOrder By Decending: ");

List<int> list4 = new List<int>() { 4,3,5,1,2};

//var Data =list4.Order();
//var Data =list4.OrderDescending();
var Data =list4.OrderBy(i=>i%2==0);

foreach (var item in Data) {

    Console.WriteLine(item);
}

Console.WriteLine("\nThen By");

List<Student>  Data2= Student.getAll();



var x = Data2.OrderBy(s=>s.Name);
foreach (var item in x)
{

    Console.WriteLine($"RollNO: {item.RollNo}\t Name: {item.Name}\t Age: {item.Age} ");

}
Console.WriteLine("Then by Age: ");


var y =x.ThenBy(x=>x.Age);

foreach (var item in y)
{

    Console.WriteLine($"RollNO: {item.RollNo}\t Name: {item.Name}\t Age: {item.Age} ");

}

Console.WriteLine();*/



Console.WriteLine("*******************************************************************************");
Console.WriteLine("*******************************************************************************");

Console.WriteLine("\nSorting");
/*
List<int> list = new List<int>() { 12,5,3,2,7,5};

Console.WriteLine("\nSort(): public void Sort()");
Console.WriteLine("Current list is: List<int>() { 12,5,3,2,7,5} after sort:");
list.Sort();

foreach (int i in list) { 
    Console.WriteLine(i);
}


List<Student> obj1 = Student.getAll();
obj1.Sort();

obj1.Sort((student1, Student2) =>
{
    if(student1==null && Student2==null) return 0;
    if (student1 == null) return -1;
    if(Student2==null)return 1;
    return student1.Age.CompareTo(Student2.Age);

});

foreach (var item in obj1)
{
    if (item == null) {

        Console.WriteLine("NUll Student");
    }else
        Console.WriteLine($"RollNO: {item.RollNo}\t Name: {item.Name}\t Age: {item.Age} ");
}

//  public void Sort(IComparer<T>? comparer)





List<int> obj2 = new List<int>() {10,20,30,12,23};

List<Student> obj3 = new List<Student>()
{
    new Student(){RollNo=14,Name = "Ajay"},
    new Student(){RollNo=13,Name="Anjali"},
    new Student(){RollNo=15,Name="Akshay"}
};

obj3.Sort((x,y)=>x.CompareTo(y));

Console.WriteLine("\nAfter Sort");
foreach (var item in obj3) {

    Console.WriteLine($"RollNo= {item.RollNo}  Name: {item.Name}");
    
}*/



Console.WriteLine("\nComparer");

List<String> list = new List<string>() { 

    "a","b","d" , "c","b"
};

list.Sort();

foreach (String s in list) { 

    Console.WriteLine(s);
}


/*
IEnumerable<string> list1=list.Distinct();

foreach(string item in list1) { 

    Console.WriteLine(item);
}*/

List<Student> ls = Student.getAll();
//ls.Sort((x,y)=>x.RollNo.CompareTo(y.RollNo));
ls.Sort(new StudentComparer());

//Comparison<Student> ls1 = Student.myMethod;
Comparison<Student> ls1 = delegate (Student x, Student y)
{
    return x.Name.CompareTo(y.Name);
};

//Comparison<Student> ls1 = (x, y) =>x.RollNo.CompareTo(y.RollNo);

ls.Sort((x,y)=>x.RollNo.CompareTo(y.RollNo));

ls.Sort(ls1);

foreach (Student item in ls) { 

       // Console.WriteLine($"RollNO: {item.RollNo}\t Name: {item.Name}\t Age: {item.Age} ");
}


List<Student> students= Student.getAll();
//students.Sort(1, 2, Comparer<Student>.Create((x, y) => x.RollNo.CompareTo(y.RollNo)));
students.Sort(0, 4, new StudentComparer());

foreach (Student item in students) {
    Console.WriteLine($"RollNO: {item.RollNo}\t Name: {item.Name}\t Age: {item.Age} ");


}


