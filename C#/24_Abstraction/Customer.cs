
/*static class A {

    public static int x = 10;
   // int id = 20;

    public static void fun() {

        Console.WriteLine(x);

    }
}*/


public abstract class Customer
{


    public  void showTiming()
    {

        Console.WriteLine("*** All Shows Timing ***");
    }
    public virtual void showCurrentTime()
    {
        DateTime now = DateTime.Now;
        Console.WriteLine("Current Date and Time: " + now);
    }
    public Customer() {
        Console.WriteLine("Default Customer() Constructor");
    }
    public abstract void printTicket();
}

