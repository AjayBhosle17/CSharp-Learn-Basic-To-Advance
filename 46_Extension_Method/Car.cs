public interface ICar {

}
 
public class Audi : ICar { 

}

public class BMW : ICar { 

}

public static class classHelper {

    public static void print(this ICar a , string CustomerName) {

        Console.WriteLine($"{a.GetType().Name}  Customer_Name = {CustomerName}");

    }
}
