public partial class Customer:A,C{
    public static int y =20;
    char dGroup = 'A';
    public Customer()
    {
        Id = 10;
        Name = "Ajay";
    }

    //public partial void Details();
    public partial void Details() {

        Console.WriteLine("Customer2 Details() method Called");
    }

    // public void fun();

    public void gun() {

        Console.WriteLine("Hii Hell gun() method called");
    }

    static Customer() {

        Console.WriteLine("Static constructor called");
    }
}

public class A { 

}
interface C { 


}

public class D
{

}