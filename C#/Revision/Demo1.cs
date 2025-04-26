public partial class Demo
{

   
    public string Name { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
    }
}

public class Demo1 : Demo
{
    public void ShowDetails()
    {
        Console.WriteLine("This is Demo1 class");
    }
}
