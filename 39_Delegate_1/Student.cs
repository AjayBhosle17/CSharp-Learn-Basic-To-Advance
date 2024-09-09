

public delegate void printdelegate();
public delegate string Fullname(string firstName,string lastName);
public delegate int OddNumber();
public class Student {


    public void printA(printdelegate del) {

        del();
        Console.WriteLine("PrintA () Called");
    }
    public void printB()
    {

        Console.WriteLine("PrintB () Called");
    }
    public void printC()
    {

        Console.WriteLine("PrintC () Called");
    }

    public string PrintD(string firstName , string lastName) {

        return $"Fullname {firstName} {lastName}";

    }

    public int printOdd(OddNumber od) {

        
        return od();
    }
}