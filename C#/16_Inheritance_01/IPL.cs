// Inheritance Types

#region Single level Inheritance
/*public class IPL:BCCI {

    public IPL()
    {
        noOfPlayer = 12;
    }

   *//* public void display() {

        Console.WriteLine("\nIPL Data");
        Console.WriteLine($"Mode Of Cricket : {modeOfCricket}");
        Console.WriteLine($"NO of player: {noOfPlayer}");
    }*//*

}*/
#endregion

#region Multi_Level Inheritance
/*public class Parent : GrandFather {

    public void AddProperty() {

        Console.WriteLine("\nParent Data");
        Console.WriteLine("Grand + Parent  self Property");
    }
}

public class Child : Parent {

    public void AddBothProperty() {

        Console.WriteLine("\nChild Data");
        Console.WriteLine("GrandFather + Parent + child  self Property");
    }
}*/

#endregion

#region Hierachical Inheritance

public class Student1 : Company {

    public string student_Name = "Ajay Bhosle";

    public void details1() { 
    
        Console.WriteLine($"Student Name: {student_Name}");
    }

}


public class Student2 : Company
{

    public string student_Name = "Zahid Mujawar";

    public void details2()
    {

        Console.WriteLine($"Student Name: {student_Name}");
    }
}

#endregion


// hybrid inhritance not support
// Multiple inheritance also Not Support