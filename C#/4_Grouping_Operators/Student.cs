
public class Student
{

    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public List<Student> getAll() {
        return new List<Student> {
            new Student(){ Id= 1 ,Name="Ajay" , Salary= 40000, Age = 22 ,Gender="Male"},
            new Student(){ Id= 2 ,Name="Snehal" , Salary= 50000, Age = 12,Gender="Female" },
            new Student(){ Id= 3 ,Name="jay" , Salary= 40000, Age = 22 ,Gender="Male"},
            new Student(){ Id= 4 ,Name="Vaishnavi" , Salary= 75000, Age = 19,Gender="Female"}
        };
    }
}