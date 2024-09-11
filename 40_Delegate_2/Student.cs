public class Student {

    public int RollNo { get; set; }
    public String Name { get; set; }
    public string gender { get; set; }
    public DateTime dateOfBirth { get; set; }
    public bool ismeritListed { get; set; }

    public Student(String Name, int no) {

        Console.WriteLine($"Name : {Name} no : {no}");
    }

    public Student():this("Ajay",0) {
   
        Console.WriteLine("Default_Constructor");

    }
    
}





















/*public class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public DateTime DateofBirth { get; set; }

    public bool IsMeritListed { get; set; }
}*/










