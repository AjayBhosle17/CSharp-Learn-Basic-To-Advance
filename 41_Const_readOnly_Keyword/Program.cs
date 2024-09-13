

Student obj = new Student();
obj.RollNo = 1;
obj.name = "Ajay Bhosle";
//obj.id = 14;
Student.id = 20;

Console.WriteLine($"RollNo : {obj.RollNo} Name: {obj.name}  id : {Student.id}");

//Student.x = 30; // We cannot change value

//obj.y = 40; // not directly assign it intialize in Constructor
Console.WriteLine(Student.x);
Console.WriteLine(obj.y);
//Console.WriteLine(obj.v);
Console.WriteLine(Student.v);




