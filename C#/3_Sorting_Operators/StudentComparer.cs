public class StudentComparer : IComparer<Student>
{
    public int Compare(Student? x, Student? y)
    {
        //nont implemented Exception
        if (x == null || y == null) return 0;
        return x.Name.CompareTo(y.Name);
    }
}

