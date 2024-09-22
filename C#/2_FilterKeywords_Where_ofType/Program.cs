

List<Student> list = new List<Student>()
{
    new Student(){RollNo= 22 , Name= "Ajay" , Gender= "Male"},
    new Student(){RollNo= 28 , Name= "Anjali" , Gender= "Female"},
    new Student(){RollNo= 13 , Name= "Krishna" , Gender= "Male"},
    new Student(){RollNo= 30 , Name= "Snehal" , Gender= "Female"},
};

Console.WriteLine("Student List Show: \n");
foreach (Student student in list)
{

    Console.WriteLine($"RollNO: {student.RollNo} \t Name : {student.Name}\t Geneder: {student.Gender} ");
}

// Where Used

Console.WriteLine($"\nWhere Used: using Method\n");
// Exceptions:
//   T:System.ArgumentNullException:
//     source or predicate is null.
//public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
//public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource,int, bool> predicate);


IEnumerable<Student> filter = list.Where(s => s.Gender == "Male");
Console.WriteLine("\nFilter Males\n");

foreach (Student item in filter)
{

    Console.WriteLine($"RollNO: {item.RollNo} \t Name : {item.Name}\t Geneder: {item.Gender} ");

}


Console.WriteLine($"\nWhere Used: Using Query:\n");

IEnumerable<Student> filtered = from s in list
                                where s.Gender == "Female"
                                select s;


Console.WriteLine("\nFilter Females\n");
foreach (Student item in filtered)
{

    Console.WriteLine($"RollNO: {item.RollNo} \t Name : {item.Name}\t Geneder: {item.Gender} ");

}

Console.WriteLine("\nFilter ROllNo: In Between 20 to 30\n");
IEnumerable<Student> filterd = list.Where(s => s.RollNo > 20 && s.RollNo < 30);


foreach (Student item in filterd)
{
    Console.WriteLine($"RollNO: {item.RollNo} \t Name : {item.Name}\t Geneder: {item.Gender} ");
}




Console.WriteLine("\nOperation with List: \n");

List<string> item3 = new List<string>() { "Ajay", "Vijay", "Om", "Vaishnavi", "Madhuri" };

IEnumerable<string> obj2=item3.Where(s => s.Length <= 5);
Console.WriteLine("s.Length <= 5 list: ");
foreach (string item in obj2) {

    Console.WriteLine(item);
}

Console.WriteLine("**************************************************************************");
Console.WriteLine("**************************************************************************");

Console.WriteLine("\nOfType\n"); // if source is null throw nullArgumentException

List<Object> list1 = new List<Object>() { 17, "Ajay", 18, 19.4f, 3.5m };

IEnumerable<int> filter1 = list1.OfType<int>();
Console.WriteLine("Only Int Type Used OfType: list is: 17,\"Ajay\" ,18, 19.4f ,3.5m  ");

foreach (int item in filter1)
{ 
    Console.WriteLine(item);
}

List<Car> item4 = new List<Car>()
{
    new Car(),new Audi(), new Car(), new Bugati(),new BMW(),new Audi(), new Car(), new Bugati()

};

var obj5=item4.OfType<Audi>();
Console.WriteLine("OfType: with Objects:\n");
foreach (Car item in obj5) { 

    Console.WriteLine(item);
}

Console.WriteLine("Operation On List: \n");
List<Object> item5 = new List<Object>() { 

    'a','b','c','d','a' ,'c',new Car(),new Audi()
};

Console.WriteLine(item5[5]);

IEnumerable<Object> item6=item5.OfType<Car>();

foreach (var i in item6) { 

    Console.WriteLine(i);
}


