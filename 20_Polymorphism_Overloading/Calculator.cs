
// No of Parameter
// Types of Parameter
//Order Of Parameter
// Kind Of Parameter
public class Calculator {

    public void Print() {

        Console.WriteLine("NO Parameter");
    }
    public void Print(int x)
    {

        Console.WriteLine($"x= {x}");
    }
    public void Print(float x)
    {
        Console.WriteLine($"x={x}");
    }

    public void Print(int x, float y)
    {

        Console.WriteLine($"sum is = {x + y}");
    }
    public void Print(float x, int y)
    {

        Console.WriteLine($"sum is = {x + y}");
    }

    public void Print(ref int x) {

        Console.WriteLine($"Print(ref int {x})");
    }

    /*public void Print(out int x)
    {                                                         //error ref and out same
        x=30
        Console.WriteLine($"Print(out int {x})");
    }
}*/

    public void Print(out float x) {

        x = 20;
        Console.WriteLine($"Print(out float { x})");
    }



    public int sum(int x, int y) {

        return x + y;

    }

    public float sum(int x, float y) {

        return x;

    }
}