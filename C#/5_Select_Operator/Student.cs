
public class Student {

    public int id { get; set; }
    public String Name { get; set; }
    public int Salary { get; set; }
    public int Age { get; set; }
    public List<String> subjects { get; set; }


    public List<Student> getAll() {

        return new List<Student>() { 
        
            new Student(){ id=1,Name="Ajay",Salary = 23000,Age=21 ,subjects=new List<string>(){"s1","s2"}},
            new Student(){ id=2,Name="jay",Salary = 32000,Age=22,subjects=new List<string>(){"s1","s3"}},
            new Student(){ id=3,Name="Vijay",Salary = 43000,Age=20,subjects=new List<string>(){"s4"}},
            new Student(){ id=4,Name="Om",Salary = 30000,Age=26 ,subjects=new List<string>(){"s2","s5"}},
        };
    }
}