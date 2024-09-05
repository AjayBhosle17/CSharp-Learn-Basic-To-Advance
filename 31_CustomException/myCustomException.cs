
#region Index Out of range
/*public class myCustomException:Exception{

    public myCustomException() :base("My Custom Exception"){
    
    }
   
    public myCustomException(string message) : base(message) { 
    
    }
}
*/
#endregion

#region divide by zero

public class myCustomException : Exception
{
    public myCustomException() : base("My Custom Exception")
    {

    }

    public myCustomException(string message) : base("My Custom Exception" + message)
    {

    }
}

#endregion