﻿
//Object create
Student s1= new Student();
s1.RollNo = 17;
s1.Name = "Ajay";
s1.Age = 22;

s1.display();


Student s2 = new Student();
s2.RollNo = 19;
s2.Name = "Anjali";
s2.Age = 22;

s2.display();

Student s3 = new Student();
s3.RollNo = 19;
s3.Name = "Anjali";
s3.Age = 22;

s3.display();

Console.WriteLine(Student.designation);
// object intializer
Student s8 = new Student(){ RollNo=20,Name="krushna" ,Age=22};
s8.display();


//Country obj1 = new Country();

//Country obj2 = new Country();


