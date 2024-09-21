

public class B : A
{

    public void print()
    {
        A obj = new A();
       // obj.print();

        Console.WriteLine(id);
        Console.WriteLine(base.id);
    }
}