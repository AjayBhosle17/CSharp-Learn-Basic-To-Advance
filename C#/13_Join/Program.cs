

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

