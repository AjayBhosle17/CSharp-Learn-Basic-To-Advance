
// this keyword
public class Student {

    public string firstName;
    public string lastName;
    public Student() {
        Console.WriteLine($"This Keyword Print: {this}"); // Student
        Console.WriteLine("Default Constructor");
    }
/*
 // Problem when field and parameter name same when u assign on that Time

    public Student(string firstName, string lastName) {

        firstName = firstName;
        lastName = lastName;

    }*/
    
    
    public Student(string firstName, string lastName)
    {
        Console.WriteLine($"this 2 print: {this}");// Student

        this.firstName = firstName;
        this.lastName = lastName;

    }

    public void PrintData() {

        Console.WriteLine($"FullName: {firstName} {lastName}");
    }

}