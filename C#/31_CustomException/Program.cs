
#region Array Index
/*

try
{
    int[] arr = new int[] { 10, 20, 30 };
    int index = 5;

    if (index >= arr.Length || index < 0)
    {

        throw new myCustomException($"index {index} is out of bound in the array");
        Console.WriteLine($"Array index {index} is = {arr[index]}");
    }

    Console.WriteLine(arr[index]);
    // Console.WriteLine("Array Elements are: ");
    *//*  for (int i = 0; i <= 4; i++) {

          if (arr.Length <=4)
          {

              throw new myCustomException("index out of range Exception");
          }

          Console.WriteLine(arr[i]);
      }*//*

}
catch (myCustomException ex) {

    Console.WriteLine($"Type name : {ex.GetType().Name}");
    Console.WriteLine($"message : {ex.Message}");
    Console.WriteLine($"{ex.StackTrace}");
}*/
#endregion

#region

try
{
    int num1 = 10;
    int num2 = 20;

    int result = divide(num1, num2);

    if (result == 0) {

        throw new myCustomException("Divide by Zero Exception");
    }
    Console.WriteLine($"result of division is = {result}");
}
catch (myCustomException ex) {

    Console.WriteLine($"Type name : {ex.GetType().Name}");
    Console.WriteLine($"message : {ex.Message}");
    Console.WriteLine($"{ex.StackTrace}");
}

static int divide(int num1 , int num2) {

    int result = num1 / num2;
    return result;
}


#endregion




Console.ReadLine();