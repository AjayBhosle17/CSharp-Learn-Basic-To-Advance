/*
class Customer
{
    public string name { get; set; }
    public int  ticketAmount { get; set; }
    public int HallNo { get; set; }

    public Customer() {

        name = "NO Name";
        Console.WriteLine("No Argument CUstomer");
    }
    public Customer(string name)
    {

        name = "NO Name";
        Console.WriteLine("Para  CUstomer");
    }
    public void showTiming()
    {
        Console.WriteLine("10:30 Am");
    }

    public bool isTicketAvailable()
    {

        return true; 
    }

}

class goldCustomer : Customer
{

    public goldCustomer() {

        ticketAmount = 350;
        HallNo = 2;
    }
    public goldCustomer(string name):base("ab") {
    
        
        this.name = name;
       
         
    }

    public void getDetails()
    {
        Console.WriteLine($"Name of Customer is : {name}");
    }

}*/

/* new */

/*class Customer
{
    public void Entry()
    {
        Console.WriteLine("10:00 AM");

    }
}
class goldCustomer : Customer
{
    public new void Entry()
    {
        Console.WriteLine("11:00 AM");
        base.Entry();

    }
}*/

/*
class Customer {

    public Customer() {

        Console.WriteLine("Default Customer");
    }

}

class GoldCustomer : Customer
{
    public GoldCustomer()
    {
        Console.WriteLine("Default GoldCustomer");
    }
}*/

/*class Addition 
{

    public virtual void Add(int x , int y) {

        Console.WriteLine($"x + y  = {x+y}");
    }

    public void Add(int x, int y,int z)
    {

        Console.WriteLine($"x + y  = {x + y}");
    }

    public void Add(int x, ref int y)
    {

        Console.WriteLine($"x + y  = {x + y}");
    }
    public void Add(out int y)
    {
        y= 0;
        Console.WriteLine($"x + y  = { y}");
    }




}

class Sub : Addition
{
    public override void Add(int x, int y)
    {
        Console.WriteLine("self Sub");
    }
}*/


/* Operator Overload*/


class Student
{
    public int Number1 { get; set; }
    public int Number2 { get; set; }


    public static Student operator+(Student obj , Student obj1)
    {
        
        Student student = new Student();

        student.Number1 = obj.Number1+obj.Number2;
        student.Number2= obj1.Number2+obj1.Number1;
        return student;

    }
}
