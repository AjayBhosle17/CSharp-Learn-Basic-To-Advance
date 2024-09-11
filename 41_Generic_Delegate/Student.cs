public class Student {

  

    public Student():this("Ajay" ,"Bhosle") {
        
        Console.WriteLine("Default Constructor");
      
    }
    public Student(string firstName, string lastname)
    {

        Console.WriteLine("Parametrized Constructor Called");
        Console.WriteLine($"FullName : {firstName} {lastname}");

    }
}