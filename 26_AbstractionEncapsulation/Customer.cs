
public class Customer {
    
   public string FirstName;
   public string LastName;

    private bool IsValid() { 
    
        return !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName);
    }
    public void Insert()
    {

        if (IsValid())
        {

            Console.WriteLine($"{FirstName} {LastName} insert SuccessFully");
        }
    }
    
}