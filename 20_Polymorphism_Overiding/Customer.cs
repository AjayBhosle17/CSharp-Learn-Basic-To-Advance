
// Here Method Hiding issue that problem Solved by Overriding
#region Method Hiding
/*
public class Customer
{

    public void print()
    {

        Console.WriteLine("Customer Print() called");
    }
    public Customer(String name)
    {

        Console.WriteLine("Customer Parametrized");
    }

}

public class SilverCustomer : Customer
{

    public new void print()
    {

        Console.WriteLine("Silver Customer Print");
    }
    public SilverCustomer(String name) : base(name)
    {
        {
            Console.WriteLine("Para");
        }
    }
}*/
#endregion

// Method Overriding
// virtul/abstract/override
class Company {

    string Company_name = "v#";
    public virtual void  details() {

        Console.WriteLine($"Company Name: {Company_name}");
    }
}

class SeniorEmployee : Company {

    string Emp_Name = "Ajay Bhosle";

    public override void details()
    {
        Console.WriteLine($"Employee Name: {Emp_Name}");
    }

}

class JuniorEmployee : SeniorEmployee {

    string Emp_name = "Datta Shinde";
    public override void details()
    {
        Console.WriteLine($"Employee Name: {Emp_name}");
    }

}



public class Parent {

    public virtual void print() {

        Console.WriteLine("Parent Method");
    }
}

public class Child : Parent {

    public override void print()
    {

        Console.WriteLine("Child Method");
    }

}