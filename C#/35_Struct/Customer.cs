
// struct

// struct is not inherit
// struct is same like class 

public struct Customer {

    public string firstName { get; set; }
    public string lastName { get; set; }

    public Customer(string fn, string ln) { 
        
        this.firstName = fn;
        this.lastName = ln;

    }
    public void print() {

        Console.WriteLine($"FullName : {firstName} {lastName}");
    }


}


public class SilverCustomer //: Customer1
{ 

} 