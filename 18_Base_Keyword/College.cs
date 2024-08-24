// Base Keyword

#region Base Keyword
/*public class College {

    public string name = "Zeal College Pune";
    public int totalDepartment = 8;

    public void details() {

        Console.WriteLine($"College Name: {name}");
        Console.WriteLine($"Total Department: {totalDepartment}");
    }


   
}*/
#endregion

#region Constructor Chain in inheritance

using System.Collections.ObjectModel;

public class College
{
  /*  public College()
    {

        Console.WriteLine("Default College() Constructor");
    }*/

    public College(String name) {

        Console.WriteLine($"College name is : {name}");
    }
}
#endregion