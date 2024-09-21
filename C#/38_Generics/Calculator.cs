using System.Numerics;

// in this class every time method is overloading so thats a promblem 
/*public class Calculator {

    public bool AreEqual(int num1,int num2) { 
            
        return num1 == num2;

    }

    public bool AreEqual(string num1, string num2) { 
    
        return num1 == num2;
    }

    public bool AreEqual(char ch1, char ch2) { 
    
        return ch1 == ch2;
    }
}*/


// create a only object parameter above problem solve but in this code No Type Safety

/*public class Calculator {

    public bool AreEqual(object num1, object num2) { 
    
        return num1 == num2;
    }
}*/

public class Calculator {

    public bool AreEqual<T>(T a, T b) { 
    
        return (a.Equals(b));  
        //return a == b; // not work on Operands
    }

    public bool AreEqual<T, U>(T a, U b) {

        return a.Equals(b);
    }

    /*public T2 AreEqual<T1, T2>(T1 a, T1 b) {

        return a.Equals(b);
    }*/
}