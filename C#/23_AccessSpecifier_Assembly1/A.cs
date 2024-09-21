/*
// Access Specifier  on members
*//*
1. Private      // same file only
2. Protected    // same class mein and also same asembly but in derived class also differnent Asembly but in derived class 
3. Public       //Access Anywhere same assembly also different Assembly
4. Internal     // Access in same assembly and also derived class but not another asembly
5. Protected Internal*//*  // same asembly with different assembly but in derived class only of different assembly

public  class A {

    // private int id = 10;
    // protected int id = 10;
    public int id = 20;
    // internal int id = 20;
    //protected internal int id = 20;

    public void print() {

        Console.WriteLine(id);
    }
}*/


// Access Specifier  on Type(class)

//1.public  -  access anywhere with different assembly
// 2.internal - access in same assembly
/*public class A {

    public int id = 20;


}*/

 public class A
{

    public int id = 20;
     void print()
    {

        Console.WriteLine(id);

    }
}
/*
internal class A {

    public int id = 20;
}
*/

