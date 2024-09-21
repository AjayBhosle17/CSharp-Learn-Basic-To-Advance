
//using AllOperations;

public class ArithmaticOperation {

    public ArithmaticOperation() {

        Console.WriteLine("Enter 1st Number");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter 2nd Number");
        int y = Convert.ToInt32(Console.ReadLine());

        Calculator obj = new Calculator(x,y);

        obj.add();
        obj.sub();
        obj.mult();
        obj.div();

    }
}

