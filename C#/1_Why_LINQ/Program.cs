
/*Student obj = new Student();

List<Student> student = obj.getDetails();

foreach (var item in student) { 

    Console.WriteLine($"RollNo ={item.RollNo}  Name = {item.Name} Gender = {item.Gender} ");
}

Console.WriteLine("Find Females");

List<Student> filter = new List<Student>();

foreach (Student item in student) {

    if (item.Gender == "Female") { 
    
        filter.Add(item);
    }
}
foreach (Student item in filter)
{
    Console.WriteLine($"RollNo ={item.RollNo}  Name = {item.Name} Gender = {item.Gender} ");

}



//using Linq method Syntax

Console.WriteLine("\nUsing Linq Method: ");

IEnumerable<Student> data=filter.Where(s => s.Gender.Equals("Female"));

foreach (Student item in data)
{
    Console.WriteLine($"RollNo ={item.RollNo}  Name = {item.Name} Gender = {item.Gender} ");

}


//using Query method Synatx
Console.WriteLine("\nUsing Query Method: ");

IEnumerable<Student> data1 = from item in student
                             where item.Gender=="Female"
                             select item;


foreach (Student item in data1)
{
    Console.WriteLine($"RollNo ={item.RollNo}  Name = {item.Name} Gender = {item.Gender} ");

}


*/

/*Employee obj = new Employee();
Employee[] EmpCreate = obj.EmployeeCreate();


foreach (var emp in EmpCreate) {

    Console.WriteLine($"Emp_RollNo: {emp.RollNo}\t Name: {emp.Name}\t Salary: {emp.Salary}");
}

Console.WriteLine("\nFilter Out Max Salary Employee\n");

Employee maxSal=obj.maxSalary(EmpCreate);

Console.WriteLine($"Emp_RollNo: {maxSal.RollNo}\t Name: {maxSal.Name}\t Salary: {maxSal.Salary}");

*/


/*
List<Employee> ls = new List<Employee>() { 

    new Employee(){id=1,name = "Ajay Bhosle" , Salary = 45000},
    new Employee(){ id= 2 , name = "Vijay Bhosle" ,Salary = 71000},
    new Employee(){ id = 3 , name = "Akshay", Salary= 23000}
};

foreach (Employee e in ls) {

    Console.WriteLine($"Emp_RollNo: {e.id}\t Name: {e.name}\t Salary: {e.Salary}");

}
Console.WriteLine("\n using list");

Employee obj = new Employee() { id = 20 , name = "Omkar" , Salary = 12000};

List<Employee> list = new List<Employee>();
list.Add(obj);




foreach (Employee item in list) { 

    Console.WriteLine($"Emp_RollNo: {item.id}\t Name: {item.name}\t Salary: {item.Salary}");

}*/


Employee[] emp = new Employee[] { 

    new Employee() { id =1 , name="Ajay Bhosle" ,Salary = 31000},
    new Employee() { id =2 , name="Vijay Bhosle" ,Salary = 30000},
    new Employee() { id =3 , name="jay Bhosle" ,Salary = 28000}

};

foreach (var  e in emp) {

    Console.WriteLine($"Emp_RollNo: {e.id}\t Name: {e.name}\t Salary: {e.Salary}");

}

Console.WriteLine("\nMax Salary: \n");

Employee Maxval = emp[0];

foreach (var e in emp) {

    if (Maxval.Salary < e.Salary) {

        Maxval = e;
    }
}
Console.WriteLine($"Emp_RollNo: {Maxval.id}\t Name: {Maxval.name}\t Salary: {Maxval.Salary}");


StringHelper.MyMethod(new Employee() { id = 1, name = "Ajay" }, "Ajay Bhosle");


