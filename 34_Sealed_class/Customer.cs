
// sealed

//static class by default sealed
// sealed class not inherit
//

/*public sealed class Customer
{
     static Customer() {

        Console.WriteLine("Private() Constructor");
    }
    public static int a = 10;


}

public class Child : Customer { 

    public void print()
    {

        Console.WriteLine(a);

    }

}*/



// sealed method 

public class Parent {

    public virtual void property() {

        Console.WriteLine("Parent Property");
    }
   public  int a = 20;
}

public  class Child : Parent {

    public sealed override void property()
    {
        Console.WriteLine("Parent + self property");
    }
}

public class customer : Child {

    // cannot override sealed method
    public override property() {

        Console.WriteLine("Add");
    }
}