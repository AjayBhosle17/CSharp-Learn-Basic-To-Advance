public class Company {

    public string name;
    public Employee[] employee;

    /*public Company(Employee[] emp)
    {
        employee= emp;
    }*/

    public void display() {

        if (employee != null || employee.Length > 0) {

            foreach (Employee e in employee) { 
            
                Console.WriteLine($"Id= {e.Id} , Name= {e.Name} , City= {e.City}");
            }
        }
    }
}