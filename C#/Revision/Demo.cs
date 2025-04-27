using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    internal class Demo
    {

        int[] arr = new int[] { 10, 20, 30, 40 };
       public void fun()
        {
            Action greet=() => Console.WriteLine("Hii");
            greet();


            Action<int, int> sum = (int x, int y) => Console.WriteLine(x + y);


            Predicate<int> arr = (int number) => number % 2 == 0;



            Func<int, int> data = (x) => x+20;

            int data1 = data(10);

            Console.WriteLine(data1);

            //Console.WriteLine(arr(5));
            //Console.WriteLine(arr(10));


            //Console.WriteLine(arr(20));
        }

    }
}
