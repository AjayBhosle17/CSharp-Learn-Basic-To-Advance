
public class Course {

    public int id { get; set; }
    public string Course_Name { get; set; }

    public List<Course> getAll() {

        return new List<Course>() {

            new Course(){ id = 1 , Course_Name = "DotNet"},
            new Course(){ id = 2 , Course_Name = "FrontEnd"}
        };
    }
}
