
public class Y : A
{

    public void print()
    {
        A obj = new A();

        Console.WriteLine(id);
        Console.WriteLine(base.id);
    }
}