public class Fees {

    public void printFees() {

        Console.WriteLine("Total fees is 50000/-");

    }
}
public interface IBatch23 {

    static int x = 20;
    //int y = 20;

    //public IBatch23() { 
    

    //}
    static IBatch23() {
        Console.WriteLine(x);
        Console.WriteLine("Static Constructor");
    }
    public abstract void BatchTime();
    static IBatch23(){

	Console.WriteLine("Static constructor Called");
    }
    //void BatchTime();  //above line and this line is same 
}
public interface IBatch24 { 

    void BatchTime();
}

public class Batch : Fees, IBatch23, IBatch24{

    public void BatchTime()             // implicitly & also compulsory write public
    {
        Console.WriteLine("Time is 8:30 to 10:30");

    }

    void IBatch23.BatchTime()             // explictly  not write here public otherwise error
    {
        Console.WriteLine("Time is 8:30 to 10:30");

    }
    void IBatch24.BatchTime()             // explictly not write here public otherwise error
    {
        Console.WriteLine("Time is 10:30 to 12:30");

    }
}


public interface IA
{

    void printA();
}
public interface IB { 

    void printB();
}

public interface IC : IA, IB { 


}

class A : IC { 

    public void printA() { Console.WriteLine("printA () Called"); }
    public void printB() { Console.WriteLine("PrintB() Called"); }
}


public abstract class Parent
{
    public abstract void printAB();
}

public abstract class Child : Parent
{
}

// Concrete implementation of Child
public class ConcreteChild : Child
{
    public override void printAB()
    {
        Console.WriteLine("printAB() in ConcreteChild");
    }
}

/*
public class AI
{


}
//public interface IIA:AI {   // Error  interface can not  inherit class

//}*/