/*public class Student {

    public int RollNo { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }



    public List<Student> getDetails() {

        return new List<Student>()
        {

            new Student(){RollNo = 1,Name="Ajay",Gender = "Male"},
            new Student(){RollNo = 2,Name="Snehal",Gender = "Female"},
            new Student(){RollNo = 3,Name="jay",Gender = "Male"}

        };

    }
}*/


/*public class Employee { 

    public int RollNo { get; set; }
    public string Name { get; set; }
    public long Salary { get; set; }


    public Employee[] EmployeeCreate() {

        Employee[] employees = new Employee[] {

            new Employee(){RollNo = 1,Name="Mayur Bhosle" , Salary= 350000 },
            new Employee(){RollNo = 2,Name = "Akshay Jondhale" , Salary = 370000 },
            new Employee(){RollNo = 3,Name = "Ajay Bhosle" , Salary = 750000 },
            new Employee(){RollNo = 4,Name = "Sameer Shaikh", Salary= 450000}
        };
        return employees;
    }

    public Employee maxSalary(Employee[] emp) { 
        
        Employee maxSal = emp[0];

        for(int i= 0; i<emp.Length; i++){

            if (maxSal.Salary < emp[i].Salary) { 
            
                maxSal = emp[i];
            }
        }
        return maxSal;
    }
}*/

public class Employee {

    public int id { get; set; }
    public string name { get; set; }

    public int Salary { get; set; }

    
}

public static class StringHelper {

    public static void MyMethod(this Employee e, string name)
    {

        Console.WriteLine($"{name.ToUpper()}");
        Console.WriteLine($"{e.id}");
        Console.WriteLine($"{e.name}");


    }
}






