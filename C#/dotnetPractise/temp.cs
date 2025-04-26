
/* static and instance*/

/*class temp
{
    static int a = 3;

    int b = 4;
    public void fun()
    {
        Console.WriteLine("fun() called");
        temp obj = new temp();
        //Console.WriteLine(obj.a);
    }
    public static void gun()
    {
        Console.WriteLine("gun() called");
        temp obj = new temp();
        Console.WriteLine(obj.b);
    }
}*/

/*All Operation from constructor*/
/**/

/*class Student
{
    public string firstName;
    public string lastName;
    public Student()
    {
        Console.WriteLine("Default Constructor")    ;
    }
    public Student(string firstname,string lastName)
    {
        this.firstName = firstname ;
        this.lastName = lastName ;
        Console.WriteLine("parameter Constructor");
    }

    public Student(Student student) {

        firstName=student.firstName;
        lastName=student.lastName;
    }
    public void Details()
    {
        Console.WriteLine($"firstName: {firstName} lastName: {lastName}");
    }


}*/

/*class Student
{
    public string firstName { get; set; }
    public string lastName { get; set; }

    public Student(string FirstName,string LastName)
    {
        firstName=FirstName;
        lastName=LastName;
    }

    public Student(Student student)
    {
        firstName=student.firstName;
        lastName=student.lastName;
    }
    public void getDetails()
    {
        Console.WriteLine($"firstName: {firstName} LastName: {lastName}");
    }
}*/

//class Student
//{
//    private Student()
//    {

//        Console.WriteLine("Private Constructor");
//    }
//}


interface demo {

    public int MyProperty { get; set; }
    static int x = 10;
    void Demo1()
    {
        Console.WriteLine("hii");
    }
}