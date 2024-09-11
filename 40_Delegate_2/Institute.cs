
/*
public delegate bool discount(Student s);

public delegate void PrintStudent();
public class Institute { 

    public string Name { get; set; }
    private Student[] _student;

    public Institute(Student[] students ) {
        
        _student = students;
    
    }

    public void PrintAllStudent() {

        Console.WriteLine($"Institute Name: {Name}");

        if (_student != null && _student.Length > 0)
        {

            foreach (Student student in _student)
            {
                Console.WriteLine($"RollNO: {student.RollNo}" + $" Name : {student.Name} " + $" DOB : {student.dateOfBirth}   ismeritListed :{student.ismeritListed}");
            }
        }
        else {

            Console.WriteLine("No Student Found");

        }
    }
  
    public void EligibleForDiscount(discount criteria) {

        Console.WriteLine("\n\n\n");

        if (_student != null && _student.Length > 0)
        {

            foreach (Student student in _student) {


               // if (student.ismeritListed) {
               if(criteria(student))
                { 

                    Console.WriteLine($"{student.Name} Eligible for Discount");
                }
            }
        }
        else {

            Console.WriteLine("No student found to check Discount");
        }
    }

    public void printA(PrintStudent obj) {

        obj();

        Console.WriteLine("printA() Called");

        if (_student.Length > 0 && _student != null) {

            foreach (Student student in _student) {

                if (student.gender == "female") {

                    Console.WriteLine("Eligible");
                }
            }
        }
        
    }
    public static bool IsFemale(Student s)
    {
        return s.gender == "Female";
    }


}*/


//public delegate bool discount(Student s);

//public delegate void PrintStudent();
public class Institute
{

    public string Name { get; set; }
    private Student[] _student;

    public Institute(Student[] students)
    {

        _student = students;

    }

    public void PrintAllStudent()
    {

        Console.WriteLine($"Institute Name: {Name}");

        if (_student != null && _student.Length > 0)
        {

            foreach (Student student in _student)
            {
                Console.WriteLine($"RollNO: {student.RollNo}" + $" Name : {student.Name} " + $" DOB : {student.dateOfBirth}   ismeritListed :{student.ismeritListed}");
            }
        }
        else
        {

            Console.WriteLine("No Student Found");

        }
    }

    public void EligibleForDiscount(Predicate<Student> criteria)
    {

        Console.WriteLine("\n\n\n");

        if (_student != null && _student.Length > 0)
        {

            foreach (Student student in _student)
            {


                // if (student.ismeritListed) {
                if (criteria(student))
                {

                    Console.WriteLine($"{student.Name} Eligible for Discount");
                }
            }
        }
        else
        {

            Console.WriteLine("No student found to check Discount");
        }
    }

    public void printA(Action obj)
    {

        obj();

        Console.WriteLine("printA() Called");

        if (_student.Length > 0 && _student != null)
        {

            foreach (Student student in _student)
            {

                if (student.gender == "female")
                {

                    Console.WriteLine("Eligible");
                }
            }
        }

    }
    public static bool IsFemale(Student s)
    {
        return s.gender == "Female";
    }


}



























/*// public delegate bool DiscountCriteria(Student s);

public class Institute
{
    public string Name { get; set; }

    private Student[] _students;

    public Institute(Student[] students)
    {
        _students = students;
    }

    public void PrintAllStudents()
    {
        Console.WriteLine($"Institute Name : {Name}");

        if (_students != null && _students.Length > 0)
        {
            foreach (Student student in _students)
            {
                Console.WriteLine($"RollNumber : {student.RollNumber} " +
                    $"Name : {student.Name} Gender : {student.Gender} " +
                    $"DOB : {student.DateofBirth} Was in Merit : {student.IsMeritListed}");
            }
        }
        else
        {
            Console.WriteLine("NO STUDENTS FOUND");
        }
    }

    // public void StudentsEligibleForDiscount(DiscountCriteria criteria)
    public void StudentsEligibleForDiscount(Predicate<Student> criteria)
    {
        if (_students != null && _students.Length > 0)
        {
            Console.WriteLine("*** Discount Eligible Students ***");
            foreach (Student s in _students)
            {
                // if (s.IsMeritListed)
                if (criteria(s))
                {
                    Console.WriteLine($"{s.Name} is eligible for discount");
                }
            }
        }
        else
        {
            Console.WriteLine("No Student Found To Check Discount Eligibility");
        }
    }
}*/