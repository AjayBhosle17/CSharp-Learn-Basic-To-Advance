public class Student {

    public int RollNo { get; set;}
    public string Name { get; set; }

    public int Age { get; set; }

    public static  List<Student> getAll() {

        return new List<Student>()
        {
            new Student() { RollNo =17 , Name = "Ajay" , Age = 20},
            new Student(){ RollNo = 18 , Name = "Anjali" ,Age = 19},
            new Student(){ RollNo = 04, Name = "Abhi" ,Age = 20}
        };
    }

}