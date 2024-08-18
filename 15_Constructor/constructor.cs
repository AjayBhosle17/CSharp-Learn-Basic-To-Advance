#region Constructor Types
/*public class Student {

    public string first_Name;
    public string LastName;
    public Student() {

        
        Console.WriteLine($"Default Constructor");
    }
    public Student(string first_Name, string lastName)
    {
        Console.WriteLine("Parametrized Constructor");
    }

    public Student(Student s) {

        Console.WriteLine("Copy Constructor");
    }

    static Student() { 
    
        Console.WriteLine("Static Constructor");
    }
}*/
#endregion Constructor Types


public class Student {

    public string firstName;
    public string lastName;
    public static string Course = "DotNet";
    public Student() {

        firstName = "NO First Name";
        lastName = "No Last Name";
        //Console.WriteLine($"FullName: {firstName} + {lastName} + {Course}");

    }

    public Student(string fn, string ln)
    {
        firstName=fn;
        lastName = ln;
       // Console.WriteLine($"FullName: {firstName} + {lastName} + {Course}");
    }

    public void FullPrintName() {
        Console.WriteLine($"FullName: {firstName}   {lastName}   {Course}");

    }
}