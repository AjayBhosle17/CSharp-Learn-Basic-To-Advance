using System.Reflection.Metadata.Ecma335;

public class Student {

    public int RollNo { get; set;}
    public string Name { get; set; }

    public int Age { get; set; }

    public static  List<Student> getAll() {

        return new List<Student>()
        {
            new Student() { RollNo =17 , Name = "Ajay" , Age = 20},
            new Student(){ RollNo = 18 , Name = "Anjali" ,Age = 19},
            new Student(){ RollNo = 04, Name = "Anjali" ,Age = 10},
          //  null,
            new Student(){ RollNo = 04, Name = "Akshay" ,Age = 40}
        };
    }

    public int CompareTo(Student? other)
    {
        if (other == null) return 1;
        return this.RollNo.CompareTo(other.RollNo);
    }

    public static int myMethod(Student s1 , Student s2) {

        return s1.Name.CompareTo(s2.Name);
    }

}