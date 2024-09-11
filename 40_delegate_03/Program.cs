/*


Student[] obj = new Student[] {

    new Student(){ RollNo=17,Name="Ajay",gender ="male",dateOfBirth=DateTime.Parse("27/06/2002"),ismeritListed=true},
    new Student(){ RollNo=4,Name="Abhi",gender ="male",dateOfBirth=DateTime.Parse("4/8/2002"),ismeritListed=false},
    new Student(){ RollNo=17,Name="Snehal",gender ="Female",dateOfBirth=DateTime.Parse("4/09/2002"),ismeritListed=true},
    new Student(){ RollNo=17,Name="Om",gender ="male",dateOfBirth=DateTime.Parse("12/04/2002"),ismeritListed=false},

};

Institute obj1 = new Institute(obj) { Name = "V# Technologies"};

obj1.PrintAllStudent();



discount dd1 = Institute.IsFemale;
obj1.EligibleForDiscount(dd1);


discount dd = delegate (Student s)
{
    return s.ismeritListed;

};
obj1.EligibleForDiscount(dd);

obj1.EligibleForDiscount((Student s) => s.ismeritListed);


// cdac 

Student[] obj2 = new Student[] {

new Student(){ RollNo = 1, Name = "Ajay", gender = "male",
    ismeritListed = false, dateOfBirth = DateTime.Parse("01/01/1990")},
new Student(){ RollNo = 2, Name = "sneha", gender = "female",
    ismeritListed = true, dateOfBirth = DateTime.Parse("09/10/1994")},
new Student(){ RollNo = 3, Name = "parmeshwar", gender = "male",
    ismeritListed = false, dateOfBirth = DateTime.Parse("12/07/2000")},
new Student(){ RollNo = 4, Name = "yashwant", gender = "male",
    ismeritListed = true, dateOfBirth = DateTime.Parse("11/05/1996")}
};

Institute obj3 = new Institute(obj2) { Name = "CDAC" };

obj3.PrintAllStudent();


discount dd4 = delegate (Student s)
{
    return s.gender=="male";
};
obj3.EligibleForDiscount(dd4);


PrintStudent obj8 = delegate ()
{
    Console.WriteLine("Hii Hello");

};

obj1.printA(obj8);
obj8 = () => Console.WriteLine("Hii hello");
obj1.printA(obj8);

discount dd5 = delegate (Student s)
{

    return s.Name.StartsWith('A');
};
obj3.EligibleForDiscount(dd5);*/






Student[] obj = new Student[] {

    new Student(){ RollNo=17,Name="Ajay",gender ="male",dateOfBirth=DateTime.Parse("27/06/2002"),ismeritListed=true},
    new Student(){ RollNo=4,Name="Abhi",gender ="male",dateOfBirth=DateTime.Parse("4/8/2002"),ismeritListed=false},
    new Student(){ RollNo=17,Name="Snehal",gender ="Female",dateOfBirth=DateTime.Parse("4/09/2002"),ismeritListed=true},
    new Student(){ RollNo=17,Name="Om",gender ="male",dateOfBirth=DateTime.Parse("12/04/2002"),ismeritListed=false},

};

Institute obj1 = new Institute(obj) { Name = "V# Technologies" };

obj1.PrintAllStudent();



Predicate<Student> dd1 = Institute.IsFemale;
obj1.EligibleForDiscount(dd1);


Predicate<Student> dd = delegate (Student s)
{
    return s.ismeritListed;

};
obj1.EligibleForDiscount(dd);

obj1.EligibleForDiscount((Student s) => s.ismeritListed);


// cdac 

Student[] obj2 = new Student[] {

new Student(){ RollNo = 1, Name = "Ajay", gender = "male",
    ismeritListed = false, dateOfBirth = DateTime.Parse("01/01/1990")},
new Student(){ RollNo = 2, Name = "sneha", gender = "female",
    ismeritListed = true, dateOfBirth = DateTime.Parse("09/10/1994")},
new Student(){ RollNo = 3, Name = "parmeshwar", gender = "male",
    ismeritListed = false, dateOfBirth = DateTime.Parse("12/07/2000")},
new Student(){ RollNo = 4, Name = "yashwant", gender = "male",
    ismeritListed = true, dateOfBirth = DateTime.Parse("11/05/1996")}
};

Institute obj3 = new Institute(obj2) { Name = "CDAC" };

obj3.PrintAllStudent();


Predicate <Student> dd4= delegate (Student s)
{
    return s.gender == "male";
};
obj3.EligibleForDiscount(dd4);


Action obj8 = delegate ()
{
    Console.WriteLine("Hii Hello");

};

obj1.printA(obj8);
obj8 = () => Console.WriteLine("Hii hello");
obj1.printA(obj8);


Predicate<Student> dd5 = delegate (Student s)
{

    return s.Name.StartsWith('A');
};
obj3.EligibleForDiscount(dd5);


Student st1 = new Student();
























/*Student[] students = new Student[]
{
new Student(){ RollNumber = 1, Name = "ajay", Gender = "male",
    IsMeritListed = false, DateofBirth = DateTime.Parse("01/01/1990")},
new Student(){ RollNumber = 2, Name = "manjiri", Gender = "female",
    IsMeritListed = true, DateofBirth = DateTime.Parse("09/10/1994")},
new Student(){ RollNumber = 3, Name = "jahid", Gender = "male",
    IsMeritListed = false, DateofBirth = DateTime.Parse("12/07/2000")},
new Student(){ RollNumber = 4, Name = "samir", Gender = "male",
    IsMeritListed = true, DateofBirth = DateTime.Parse("11/05/1996")}
};





Institute seed = new Institute(students) { Name = "SEED INFOTECH" };
seed.PrintAllStudents();

//DiscountCriteria del1 = delegate (Student s)
//{
//    return s.IsMeritListed;
//};

Predicate<Student> del1 = delegate (Student s)
{
    return s.Name.StartsWith("s");
};

seed.StudentsEligibleForDiscount(del1);

// cdac institute

Student[] students1 = new Student[]
{
new Student(){ RollNumber = 1, Name = "anurag", Gender = "male",
    IsMeritListed = false, DateofBirth = DateTime.Parse("01/01/1990")},
new Student(){ RollNumber = 2, Name = "sneha", Gender = "female",
    IsMeritListed = true, DateofBirth = DateTime.Parse("09/10/1994")},
new Student(){ RollNumber = 3, Name = "parmeshwar", Gender = "male",
    IsMeritListed = false, DateofBirth = DateTime.Parse("12/07/2000")},
new Student(){ RollNumber = 4, Name = "yashwant", Gender = "male",
    IsMeritListed = true, DateofBirth = DateTime.Parse("11/05/1996")}
};

Institute cdac = new Institute(students1) { Name = "CDAC" };
cdac.PrintAllStudents();

Predicate<Student> del2 = delegate (Student s)
{
    return s.Gender.Equals("female");
};

cdac.StudentsEligibleForDiscount(del2);



Console.ReadLine();*/