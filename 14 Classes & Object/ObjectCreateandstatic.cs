
class Student { 
    
    public int RollNo;  // instance /Non static
    public string Name; // instance /Non static
    public int Age=22;  // instance /Non static
    public static string designation = "Software Developer"; // static 

    public void display() {   // non-static / instance method

        Console.WriteLine($"RollNo : {RollNo} Name : {Name} Age : {Age} designation:{designation}");
    } // In non static method  to access static with nonstatic

    public static void Print() {

        Console.WriteLine("Static Print() method called");
        Console.WriteLine($"designation = {designation}");
        
        // in static method does not access non static 

        //Console.WriteLine($"Age = {Age}"); // error  
    }

}
static class Country {

    
    static string capital = "Delhi";  
}