

using System.Linq;

Student student = new Student();

List<Student> students= student.GetDeatils();

Console.WriteLine("All Student: ");

foreach (Student item in students) { 

    Console.WriteLine($"Id = {item.id}\t Name:{item.Name}\t Gender:{item.Gender}\t TrainerId: {item.TrainerId}");
}

Trainer trainer = new Trainer();
List<Trainer> trainers = trainer.getdetails();

Console.WriteLine("\nAll Trainers: ");


foreach (Trainer item in trainers)
{
    Console.WriteLine($"Id = {item.id}\t Name:{item.Name}\t Experience:{item.Experience}\t");

}
/*

// join

var join1 = students.Join(trainers, s => s.TrainerId, t => t.id, (s, t) => new
{
    Student=s ,Trainer =t 
});

Console.WriteLine("Inner Join");

foreach (var item in join1) {

    Console.WriteLine($"StudentName : {item.Student.Name}   TrainerName: {item.Trainer.Name}");
}


List<string> strings = new List<string>();

IEnumerable<string> str = Enumerable.DefaultIfEmpty(strings);

Console.WriteLine(str.FirstOrDefault()==null? "null" :str.DefaultIfEmpty());


Console.WriteLine("\nGroup Join: ");


var group_Join = students.GroupJoin(trainers, s => s.TrainerId, t => t.id, (s, t) =>
new{
    Student = s.Name,  Trainer = t.FirstOrDefault(tt=>tt.id==s.TrainerId)?.Name
});


foreach (var i in group_Join) {

    Console.WriteLine($"Student_Name: {i.Student} \t Trainer_Name: {i.Trainer}" );
}



// Using Query


var join_Query = from s in students
                 join t in trainers
                 on s.TrainerId equals t.id
                 select new
                 {
                     Student = s, Trainer = t
                 };

Console.WriteLine();
foreach (var item in join_Query) {
    Console.WriteLine($"StudentName : {item.Student.Name}   TrainerName: {item.Trainer.Name}");
}


var left_Join = from s in students
                join t in trainers
                on s.id equals t.id
                into temp
                from tt in temp.DefaultIfEmpty()
                select new
                {
                    Student= s ,Trainer = tt
                };
*/



// join using method

Console.WriteLine("\nInner Join");
var innerjoin = students.Join(trainers, s => s.TrainerId, t => t.id, (s, t) => new
{
    Student = s,Trainer = t
});

foreach (var item in innerjoin)
{
    Console.WriteLine($"Student_Name: {item.Student.Name} \t Trainer_Name: {item.Trainer.Name}");
}


// Left Join Using Method


Console.WriteLine("\nLeft Join ");

var left_Join = students.GroupJoin(trainers, s => s.TrainerId, t => t.id, (s, t) =>
new {
    Student = s , Trainer = t.FirstOrDefault(tt => tt.id == s.TrainerId)
});


foreach (var item in left_Join) {

    Console.WriteLine($"Student_Name: {item.Student.Name} \t Trainer_Name: {item.Trainer?.Name}");

}


// Right Join

Console.WriteLine("\nRight Join");

var Right_Join = trainers.GroupJoin(students, t => t.id, s => s.TrainerId, (t, s) => new
{
    Trainer = t,Student = s.FirstOrDefault(tt=>tt.TrainerId==t.id)
});
foreach (var item in Right_Join)
{

    Console.WriteLine($"Student_Name: {item.Student?.Name} \t Trainer_Name: {item.Trainer?.Name}");

}

Console.WriteLine("Problem in Right Join");


// Join Using Query


Console.WriteLine("\n\nUsing  Query");

Console.WriteLine("\nJoin Query: ");
/*IEnumerable<(string s1, string s2)> join_Query = from s in students
                                                 join t in trainers
                                                 on s.TrainerId equals t.id
                                                 select (s.Name, t.Name);

foreach (var i in join_Query) {

    Console.WriteLine($"Student Name = {i.s1}  \t Trainer Name =  {i.s2}");
}
*/

var join_Query = from s in students
                 join t in trainers
                 on s.TrainerId equals t.id
                 select new {Student =s , Trainer =t };

foreach (var item in join_Query) {

    Console.WriteLine($"Student_Name: {item.Student.Name}\t Trainer_Name: {item.Trainer.Name}");
}


// Left join using Query

Console.WriteLine("\nLeft Join Using Query: ");

var LeftJoin = from s in students
                 join t in trainers
                 on s.TrainerId equals t.id into temp
                 from tt in temp.DefaultIfEmpty()
                 select new
                 {
                     student = s.Name, trainer = tt?.Name
                 };

foreach (var item in LeftJoin) {

    Console.WriteLine($"Student_Name: {item.student}\t Trainer_Name: {item.trainer}");

}


// Right join using Query

Console.WriteLine("\nRight Join Using Query: ");

var RightJoin = from t in trainers
                  join s in students
                  on t.id equals s.TrainerId into temp
                  from tt in temp.DefaultIfEmpty()
                  select new
                  {
                      student = tt?.Name,
                      trainer=t.Name
                  };


foreach (var item in RightJoin) {

    Console.WriteLine($"Student_Name: {item.student}\t Trainer_Name: {item.trainer}");

}

Console.WriteLine("\n\nFull Join");

//var FullJoin = LeftJoin.Union(RightJoin);

var FullJoin = (from s in students
                join t in trainers
                on s.TrainerId equals t.id into temp
                from tt in temp.DefaultIfEmpty()
                select new
                {
                    student = s.Name,
                    trainer = tt?.Name
                }).Union(from t in trainers
                         join s in students
                         on t.id equals s.TrainerId into temp
                         from tt in temp.DefaultIfEmpty()
                         select new
                         {
                             student = tt?.Name,
                             trainer = t.Name
                         }
                  );



foreach (var item in FullJoin) {

    Console.WriteLine($"Student_Name: {item.student}\t Trainer_Name: {item.trainer}");

}



Console.WriteLine("\nCross Join: ");

var cross_Join = from  s in students
                 from t in trainers
                 select new
                 {
                     students = s,
                     trainer = t   
                 };

foreach (var item in cross_Join) {

    Console.WriteLine($"Student_Name: {item.students.Name}\t Trainer_Name: {item.trainer.Name}");
}



// Join Multiple Collection


Console.WriteLine("\n\nJoin Multiple Collecrion");

Course obj = new Course();
List<Course> courses = obj.getAll();


var multiple_Join = from s in students
                    join t in trainers
                    on s.TrainerId equals t.id
                    join c in courses
                    on s.TrainerId equals c.id
                    select new
                    {
                        Student = s.Name,
                        Trainer = t.Name,
                        Course = c.Course_Name
                    };


foreach (var item in multiple_Join) {

    Console.WriteLine($"Student_Name: {item.Student} \t Trainer_Name: {item.Trainer} \t Course_Name: {item.Course}");
}