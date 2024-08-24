
SilverCustomer obj=new SilverCustomer();
obj.ShowsTimings();
obj.Print();

Customer obj1 = new SilverCustomer();
obj1.ShowsTimings();
obj1.Print();

Customer obj2 = new Customer();
obj2.ShowsTimings();
obj2.Print();

Customer[] obj3 = new Customer[] {

    new Customer(),
    new SilverCustomer(),
    new GoldCustomer(),
    new PlatinumCustomer()
};

foreach (Customer obj4 in obj3) {

    obj4.Print();
}

