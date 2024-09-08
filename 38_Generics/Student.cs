public class Student<T1 ,T2 > {

    public void Add<T>(T1 a, T1 b) {

        dynamic x = a;
        dynamic y = b;

        Console.WriteLine(x+y);
    }

}