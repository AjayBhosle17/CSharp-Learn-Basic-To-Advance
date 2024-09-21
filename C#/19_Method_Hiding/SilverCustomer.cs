public class SilverCustomer : Customer
{
    public new void ShowsTimings()
    {
        Console.WriteLine("*** ALL TODAYS SHOWS AVAILABLE FOR SILVER ***");
    }

    public new void Print()
    {
        Console.WriteLine("SILVER CUSTOMER");
    }
}

public class GoldCustomer : Customer
{
    public new void Print()
    {
        Console.WriteLine("GOLD CUSTOMER");
    }
}

public class PlatinumCustomer : Customer
{
    public new void Print()
    {
        Console.WriteLine("PLATINUM CUSTOMER");
    }
}