public class Parent {
    public int property;
    public void printA() {

        Console.WriteLine("PrintA () Called");
    }
}

public class Child:Parent{


    public override bool Equals(object? obj)
    {
        Child obj1 = obj as Child;
        return this.property.Equals(obj1.property);


    }
    Parent obj3 = new Parent();

    public void printB() {

        Console.WriteLine("PrintB () Called");
    }
    public void printC() {

        Console.WriteLine("PrintC () Called");
    }
	

}

