public interface ICustomer
{
    // int CustomerId;

    //public ICustomer()
    //{

    //}

    public void PrintTicket();

     void CollectFood()
    {
        Console.WriteLine("NO FOOD FACILITY AVAIALBLE");
    }
}

public class SilverCustomer : ICustomer
{
    public void PrintTicket()
    {
        Console.WriteLine("SILVER TICKET PRINTED");
    }
}

public class GoldCustomer : ICustomer
{
    public void PrintTicket()
    {
        Console.WriteLine("GOLD TICKET PRINTED");
    }
}

public class PlatinumCustomer : ICustomer
{
    public void PrintTicket()
    {
        Console.WriteLine("PLTINUM TICKET PRINTED");
    }

    public  void CollectFood()
    {
        Console.WriteLine("FOOD COLLECTED");
    }
}