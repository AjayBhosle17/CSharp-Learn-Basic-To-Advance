public partial class Customer : A, C
{
    public int Id { get; set; }
    public string Name { get; set; }

    partial void details();
    // public partial void details();
    public partial void Details();

    /*  public partial void details()
      {
          throw new NotImplementedException();
      }*/
    public static partial void AB();

    public static partial void AB() {

        Console.WriteLine("Hii it is static method");

    }

}

public class B { 

}
interface E { 

}