/*public class Parent {

    public static int x = 20;
    public static int y =20;
    public void fun() {

        Console.WriteLine("fun() method Called");
    }
}

public class Child {

    public Parent parent = new Parent();
    public void gun() {

        Console.WriteLine("Gun() method Called");
    }
}*/

// Record


public record Parent {

    public string firstName { get; set; }
    public string lastName { get; set; }

    public Parent() {

        Console.WriteLine("Parent Constructor");
    }

    public void print() {

        Console.WriteLine("Print () method");
    }
}

public record Child : Parent { 


}