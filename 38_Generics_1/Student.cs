public class Student<T1, T2>
{

    public T1 Id { get; set; }
    public T2 Name { get; set; }


    public void Add<T1>(T1 a, T1 b) {

        dynamic x = a;
        dynamic y = b;

        Console.WriteLine($"Add : {x + y}");
    }

    public Student(){

        this.Id = Id;
        this.Name= Name;
    }
    public void details() {

        Console.WriteLine($"Details : Id = {Id} Name = {Name} ");
    }

    public T1 Add(T1 a, T1 b) { 
    
        dynamic x = a;
        dynamic y = b;
        return x + y;
    }

}