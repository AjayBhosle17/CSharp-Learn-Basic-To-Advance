namespace myclasses;
public class Customer {

    public string firstName{ get; set; }
    public string lastName { get; set; }

    public void print() {

        Console.WriteLine("Customer class Print() method");
    }

    public override string ToString()
    {
        return this.firstName +" "+ this.lastName;
    }

    public override bool Equals(object? obj)
    {
        Customer c = (Customer)obj;

        Console.WriteLine(this.firstName);
        Console.WriteLine(c.firstName);
        return this.firstName.Equals(c.firstName) && this.lastName.Equals(c.lastName);
    }

    public override int GetHashCode() { 
    
        return firstName.GetHashCode() ^ lastName.GetHashCode();
    }
}
