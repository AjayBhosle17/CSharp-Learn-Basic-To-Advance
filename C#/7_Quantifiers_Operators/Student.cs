using System.Collections;

public class Student {

    public string firstName { get; set; }
    public string lastName { get; set; }

   /* public override bool Equals(object? obj)
    {
        Student student = obj as Student;

        return this.firstName.Equals(student.firstName) && this.lastName.Equals(student.lastName);
    }*/
}

public class StudentCompare : IEqualityComparer<Student>
{
    public new bool Equals(Student? x, Student? y)
    {
        return x.firstName.Equals(y.firstName)&& x.lastName.Equals(y.lastName);
    }

    public int GetHashCode(Student obj)
    {
        return obj.GetHashCode();
    }
}
