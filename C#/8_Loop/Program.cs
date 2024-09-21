//Console.WriteLine("Enter No of Rows: ");

//int rows = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= rows; i++)
//{


//    for (int j = rows; j > i; j--)
//    {
//        Console.Write("  ");
//    }
//   int w = i;
//    for (int k = 1; k <= i; k++)
//    {
//        Console.Write($" { w--}");

//    }

//    Console.WriteLine();
//}


//home work 
//Console.WriteLine("Enter No of Rows: ");
//int rows = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= rows; i++)
//{
//    //Print leading spaces
//    for (int j = rows; j > i; j--)
//    {
//        Console.Write(" ");
//    }

//    //Print numbers
//    int w = i;
//    for (int k = 1; k <= i; k++)
//    {
//        Console.Write($"{w--}");
//    }

//    //Move to the next line
//    Console.WriteLine();
//}





//Console.WriteLine("Print any");

//char ch = 'a';
//for (int i = 1; i <= 26; i++)
//{

//    Console.Write($"{ch++}  ");

//}
//int a = 1;
//for (int i = 1; i <= 5; i++)

//{
//    for (int j = 1; j <= 5; j++) ;
//    Console.Write( $"*"  );
//}







//{
//    Console.WriteLine("Enter the number of rows: ");
//    int rows = Convert.ToInt32(Console.ReadLine());

//    for (int i = 1; i <= rows; i++)
//    {
//        // Print leading spaces
//        for (int j = rows; j > i; j--)
//        {
//            Console.Write(" ");
//        }

//        // Print numbers starting from the current row number down to 1
//        for (int k = i; k >= 1; k--)
//        {
//            Console.Write(   $"{ k }");
//        }

//        // Move to the next line
//        Console.WriteLine();
//    }
//}


Console.WriteLine("Enter No of Rows");

int rows=Convert .ToInt32(Console.ReadLine());

for (int i = 1; i <= rows; i++) {
	int k = rows;
	for (int j = 1; j <= rows; j++)
	{
		if (rows - i - j + 1 > 0)
		{

			Console.Write(" *");

		}
		else {
			Console.Write($" {k}");
		}
		k--;
		
	}
    Console.WriteLine();
}


