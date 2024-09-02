
using System.Runtime.Intrinsics.Arm;

Employee[] emp = new Employee[] {


    new Employee() {Id=1,Name="Ajay",City="Pune" },
    new Employee() {Id=2,Name="Viay",City="Mumbai" },
    new Employee() {Id=3,Name="Vivek",City="Satara"}
};


//Company obj = new Company(emp);
//obj.display();



Company tata = new Company();
tata.name = "TATA";

tata.employee = emp;
tata.display();

Department  obj1 = new Department() { Id = 1, Name = "Ajay" };

Employee emp1 = new Employee()
{
    Id = 1,
    Name = "vikas",
    City = "pune",
    department = obj1,

};

Console.WriteLine($"Employee Details : " +
    $"Id : {emp1.Id} Name : {emp1.Name} City : {emp1.City} " +
    $"Department Id : {emp1.department.Id} Department Name : {emp1.department.Name}");

