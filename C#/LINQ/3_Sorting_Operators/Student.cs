

public delegate void printdelegate(); 
public class Student {

    public void printA() {

        Console.WriteLine("Print A");  
    }
    public void printB(printdelegate src) { 
        Console.WriteLine("Print B");
    
    }

    public void printC() { 
        Console.WriteLine("Print C");
    }
}