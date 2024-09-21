public class Employee { 

    public int Id;
    public string Name;
    public string City;

    public Department department;
    public Company company;

    static void Main() {


        Employee[] emp = new Employee[] {


            new Employee {Id=1,Name="Ajay",City="Pune" },
             new Employee { Id = 2, Name = "Viay", City = "Mumbai" },
             new Employee { Id = 3, Name = "Vivek", City = "Satara" }
        };

        for (int i = 0; i <= 0; i++) { 
        
            Console.WriteLine(emp[i].Id);
            Console.WriteLine(emp[i].Name);
            Console.WriteLine(emp[i].City);
        }
       // Company obj = new Company(emp);
        Console.WriteLine("Hiii");
//        obj.display();

    }

}

public class Department
{
    public int Id;
    public string Name;
}