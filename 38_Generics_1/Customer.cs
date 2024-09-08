
public class Customer {


    public bool AreEqual<T>(T a, T b) {

        return a.Equals(b);

    }

    public T2 AreEqual<T1,T2>(T1 a , T1 b) {
        dynamic x =a;
        dynamic y =b;
        return x.Equals(y);  
    }

    public bool AreEqual<T1, T2>(T1 a, T2 b) {

        return a.Equals(b);
    }
}