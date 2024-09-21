// Exception Handling

#region DivideByZeroException
/*public class Calculator {

    // System.DivideByZeroException: 'Attempted to divide by zero.'
    public void Division(int num1, int num2) {

        int x = num1 / num2;
        Console.WriteLine($"Division is : {x}");
    }



}

*/
#endregion

#region Handle Above Excepion

/*namespace Divide_Zero_Exception {

    public class Calculator {

        public void Division(int num1, int num2) {
            try {

                int result = num1/num2;
                Console.WriteLine($"Division is: {result}");

            } catch (DivideByZeroException obj) {

                Console.WriteLine("Exception Handle");
                Console.WriteLine(obj.Message);
                Console.WriteLine(obj.StackTrace);
                Console.WriteLine($"Object {obj.GetType().Name}");

            }
        }

    }
}*/
#endregion


public class Calculator
{

    public void Division(int num1, int num2)
    {
        try
        {


            int result = num1 / num2;

            if (num1 == 0) {

                throw new Exception("Exception throw");
            }

            Console.WriteLine($"Division is: {result}");

        }
        catch (DivideByZeroException obj)
        {

            Console.WriteLine("Exception Handle");
            
        }
    }
}