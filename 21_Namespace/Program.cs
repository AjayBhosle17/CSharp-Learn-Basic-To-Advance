using student1;
using standard;
using student1.user1;
public class Program { 

    static void Main(string[] args)
    {
        Console.WriteLine("Heelo NameSpace.....");

        student obj = new student();
        obj.print();

        userData obj1 = new userData();
        obj1.print();

        employee obj2 = new employee();
        obj2.print();

    }
}


