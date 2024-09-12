

// Delegate

//1 step declartion
// 2. Create instance
//3 invoke / call

public delegate void printDelgate();
public delegate string printDel();
public delegate void fullName(string s1 , string s2);
public class Customer {

    public void printA() {

        Console.WriteLine("PrintA () called");
    }
    public void printB()
    {
        Console.WriteLine("PrintB () called");
    }
    public void printC()
    {
        Console.WriteLine("PrintC () Called");
    }
    public string printD() {

        return "PrintD () Called";
    }


    public string print1() {

        return "Print1 () called";
    }

    public string print2()
    {

        return "Print2 () called";
    }

    public string print3()
    {

        return "Print3 () called";
    }
}