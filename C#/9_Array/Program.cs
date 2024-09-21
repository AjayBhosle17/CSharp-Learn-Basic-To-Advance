/*
// 1D Array

int[] arr = { 10, 20, 30, 40};
int[] arr2 = new int[] { 10, 20, 30 };



for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]} ");
}


int[] arr6 = new int[] { 1, 2, 3 };
int[][] arr1 = {new int[]{ 10, 20 }, new int[]{ 10, 20, 30 } };

int[,] arr4 =new int[2,4] { { 1, 2, 3,4 }, { 1, 2, 56,4 } };

int total = arr4.GetLength(1);

Console.WriteLine($" Total Size : {total}");   

Console.WriteLine( arr1.Length);*/



#region Jagged array

int[][] arr1 =new int[][] { new int[] { 1, 2, 3,4 }, new int[] { 1, 2, 3, 4 } };

int total_Size =  arr1[1].Length; // 
int total_Size1 = arr1[0].Length; //

int total_Rows = arr1.Length;    // calculate rows

Console.WriteLine(total_Size);
Console.WriteLine(total_Size1);
Console.WriteLine(total_Rows);
Console.WriteLine(arr1.GetLength);



int[,] arr4 = new int[2, 4] { { 1, 2, 3, 4 }, { 1, 2, 56, 4 } };

//int total = arr4.GetLength(1);

Console.WriteLine($" Total Size : {arr4.Length}");



for (int i = 0; i < arr1.Length; i++) {

	for (int j = 0; j < arr1[i].Length; j++)
	{
		Console.Write($"{arr1[i][j]} " );
	}
	Console.WriteLine();
}


#endregion 
// Multi - Dimensional

int[,] arr= new int[,] { { 10,20,30,40,60},{ 40,50,60,70,80} } ;

Console.WriteLine(arr.Length);

for (int i = 0; i < arr.GetLength(0); i++) {

	for (int j = 0; j < arr.Length/2; j++) {

		Console.Write($" { arr[i, j]}");
	}
	Console.WriteLine();	
}

foreach (int arr7 in arr)
{
	Console.WriteLine($" {arr7}");
	

}

