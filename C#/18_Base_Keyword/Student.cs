
#region Base Keyword
/*public class Student:College
{

   public int RollNo = 17;
   public  string name= "Ajay Bhosle";
    

    public void details()
    {

        Console.WriteLine($"Student Name:   {name}");
        Console.WriteLine($"Student RollNO:  {RollNo}");
        Console.WriteLine($"using this access name: {this.name}");

        //    College obj = new College();
        //    Console.WriteLine($"Access Parent Name : {obj.name}");

        Console.WriteLine($"Access Parent Name : {base.name}");

    }

}*/
#endregion

#region Constructor Chain in inheritance

public class Student : College
{

   /* public Student() : base("Ajay Bhosle")
    {

        Console.WriteLine("Default Student() Constructor");
    }*/
    public Student(String name) : base(name)
    {
        {

            Console.WriteLine($"Student name is : {name}");
        }
    }
}
#endregion