
// Method parameter types

#region 1.pass by value

/*

int rollno = 5;
student_data(rollno);
void student_data(int rollno)            // calling method
{

    Console.WriteLine($"Current RollNo : {rollno}");

    display(rollno);

    Console.WriteLine($"After called method : {rollno}");

}
void display(int rollno)                // called method
{
    rollno = 20;
    
}*/

#endregion

#region 2.pass by reference

/*

int rollno = 5;
student_data(rollno);
void student_data( int rollno)            // calling method
{

    Console.WriteLine($"Current RollNo : {rollno}");

    display(ref rollno);

    Console.WriteLine($"After called method : {rollno}");

}
void display(ref int rollno)                // called method
{
    rollno = 20;

}



void fun (ref int  num) {
    
    Console.WriteLine($"num is = {num}");
    num = 10;
}

int num = 5;
fun(ref num);
Console.WriteLine($"num is = {num}");
*/

#endregion

#region 3.pass by out
/*

int rollno = 5;
student_data(rollno);
void student_data(int rollno)            // calling method
{

    Console.WriteLine($"Current RollNo : {rollno}");

    display(out rollno);

    Console.WriteLine($"After called method : {rollno}");

}
void display(out int rollno)                // called method
{
    rollno= 12;

}

void gun(out int num) {
                                 // first assign value
    //Console.WriteLine(num);  //  error
    Console.WriteLine(num=1);
}
int num1 =5;
gun(out num1);



String str = "10";

int num;
bool result = int.TryParse(str ,out num);
*/


#endregion

#region 4.params

int[] arr = {1,2,3,4};
int x = 10;

data(x ,arr);
void data(int x ,  int[] arr) {

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();    
}


data1(1, 2, 3, 4, 5);
void data1(int x, params int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();

    Console.WriteLine($"x value is : {x}");
}


/*
void data2(params int[] arr, int x)   // Error   params is not a first parameter its always last parameter
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
*/
/*

void data3(int x , params int[] arr, params int[] arr1)   // Error   params is not a first parameter its always last parameter
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}*/




#endregion

