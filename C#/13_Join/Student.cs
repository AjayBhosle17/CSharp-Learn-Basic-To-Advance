public class Student {

    public int id { get; set; }
    public string Name { get; set; }

    public string Gender { get; set; }
    public int TrainerId { get; set; }

    public  List<Student> GetDeatils() {

        return new List<Student>(){

            new Student(){id=1,Name="Ajay",Gender="Male",TrainerId=2},
            new Student(){id=2,Name="Vikas",Gender="Male",TrainerId=1},
            new Student(){id=3,Name="Sameer",Gender="Male",TrainerId=2},
            new Student(){id=4,Name="Snehal",Gender="Female",TrainerId=1},
        };
    }
}