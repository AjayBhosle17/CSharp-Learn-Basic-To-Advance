
#region Exception Handle
/*public class Calculator {

    public void division(int num1 , int num2) {

        try
        {
            int result = num1 / num2;
            Console.WriteLine($"result is:  {result}");
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception Handle");
        }
    }
}*/
#endregion

/*
public class Calculator {

    public void division(int num1, int num2)
    {
        try
        {
            if (num2 == 0) {

               // throw new Exception("denominator is zero");
               throw new DivideByZeroException("Denominator is zero");
            }
            int result = num1/num2;
            Console.WriteLine("Operation Successful");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Exception Handle");

            Console.WriteLine($"Message name : {e.Message}");
            Console.WriteLine($"Type name : {e.GetType().Name}");

            // throw new Exception("Division () executed");
           // throw e;
            throw ;
            //  File.WriteAllText(@"D:\Coding2\Ajay V#\C#\30_Exception_2\Ajay",e.Message);

        }
      *//*  catch (Exception e)
        {
            Console.WriteLine("Exception Handle");

            Console.WriteLine($"Message name : {e.Message}");
            Console.WriteLine($"Type name : {e.GetType().Name}");

            //  File.WriteAllText(@"D:\Coding2\Ajay V#\C#\30_Exception_2\Ajay",e.Message);

        }*//*
    }
}

*/

#region finally

/*public class Calculator {

    public void Division(int num1,int num2)
    {
        try
        {

            int result = num1 / num2;

        }
        catch (Exception e)
        {
           // Console.WriteLine(e);
           throw;
        }
        finally {

            Console.WriteLine("Operation Successful");
        }
    }

}*/
#endregion
/*
public class Calculator
{

    public int Division(int num1, int num2)
    {
        try
        {

            int result = num1 / num2;
            Console.WriteLine(result);
            return result;

        }
        catch {

           // throw new Exception("Hii");
            return 0;
        }
        finally
        {
           
            Console.WriteLine("Operation Successful");
            throw new DivideByZeroException("Divide by Zero Exception");
           // return 0;
        }
    }

}*/


public class Calculator {

    public string getName()
    {
        string result = " ";
        try {

            /* throw new InvalidOperationException("Hii");
             return "Ajay";*/

            result = "Try Block";
         //   return result;
        }
        catch {

            // return "Bhosle";


            result = "Catch Block";
            return result;
        }
        finally {

            //return "Ajay Bhosle";
            result = "Finally Block";
            Console.WriteLine("Operation Successfully");

        }
        return result;
    }
}