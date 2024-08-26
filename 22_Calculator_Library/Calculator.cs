namespace AllOperations
{
    public class Calculator
    {
        public int num1;
        public int num2;

        public Calculator(int n1, int n2)
        {

            num1 = n1;
            num2 = n2;
        }

        public void add()
        {

            Console.WriteLine($"Addition is {num1} + {num2} = {num1 + num2}");

        }

        public void sub()
        {

            Console.WriteLine($"substraction  is {num1} - {num2} = {num1 - num2}");

        }
        public void mult()
        {

            Console.WriteLine($"Multiplication is {num1} * {num2} = {num1 * num2}");

        }
        public void div()
        {

            Console.WriteLine($"Division is {num1} / {num2} = {num1 / num2}");

        }


    }
}
