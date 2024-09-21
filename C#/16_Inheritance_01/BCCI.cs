// Inheritance Types

#region Single level Inheritance
/*public class BCCI {

    public string modeOfCricket = "T20";
    public int noOfPlayer = 11;


    public void display() {
        Console.WriteLine("\nBCCI Data");
        Console.WriteLine($"Mode of Cricket: {modeOfCricket}");
        Console.WriteLine($"NO of player: {noOfPlayer}");
    }

}*/
#endregion

#region Multi_Level Inheritance
/*
public class GrandFather {

    public void Property() {
        Console.WriteLine("\nGrandFather Data");
        Console.WriteLine("GrandFather self Property");
    }
    
}*/
#endregion

#region Hierachical Inheritance

public class Company {

    public string Comp_name = "Vhassh Technology pvt Ltd";
    public void details() {

        Console.WriteLine($"Company Name: {Comp_name}");

    }
}

#endregion

// hybrid inhritance not support
// Multiple inheritance also Not Support