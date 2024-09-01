public class A {

    public int id = 10;
    public virtual void Print()
    {
        Console.WriteLine(id);
    }

}

public class B { 

    public int id = 20;
    public virtual void Print()
    {
        Console.WriteLine(id);
    }
}

public class C :A,B{   // multiple inheritance means diamond problem   same method in both class so it give ambugity

}

