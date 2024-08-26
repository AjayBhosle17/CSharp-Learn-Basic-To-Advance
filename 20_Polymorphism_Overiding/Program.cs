
#region Method Hiding
/*
//Customer obj = new Customer();


SilverCustomer obj1 = new SilverCustomer("Ajay Bhosle");
obj1.print();


Customer obj2 = new SilverCustomer("Ajay");
obj2.print();
*/
#endregion

// Method Overriding

SeniorEmployee obj = new SeniorEmployee();
obj.details();

JuniorEmployee obj1= new JuniorEmployee();
obj1.details();

SeniorEmployee obj2 = new JuniorEmployee();
obj2.details();

Console.WriteLine("\n");
Company[] company = new Company[] {

    new Company(),
    new SeniorEmployee(),
    new JuniorEmployee(),
};

foreach (Company comp in company) { 

    comp.details();

}

Parent p = new Child();
p.print();
