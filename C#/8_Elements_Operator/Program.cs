
// Element Operators

#region 1.ElementAt

/*

List<int> ls = new List<int> { 1,2,3,4,5,6 };

int index = ls.ElementAt(0);

Console.WriteLine($"Index  At O: {index}");

//index= ls.ElementAt(6);   // ArgumentRangeOfException
//Console.WriteLine($"Index  At 6: {index}");
*/
#endregion

#region ElementAtOrDefault
/*
List<int> ls = new List<int> { 1, 2, 3, 4, 5, 6 };

int index=ls.ElementAtOrDefault(0);
Console.WriteLine($"Index  At O: {index}");

index = ls.ElementAtOrDefault(6);
Console.WriteLine($"Index  At 6: {index}");*/

#endregion

#region First
/*
List<int> ls = new List<int> { 1, 2, 3, 4, 5, 6 };
int index1 = ls.First();
Console.WriteLine(index1);

index1 = ls.First(num=>num%2==0);
Console.WriteLine(index1);
*//*

index1 = ls.First(num => num == 9); // InvalidOperationException

Console.WriteLine(index1);*//*


List<string> ls1 = new List<string> { "Ajay","Bhosle"};
string index = ls1.First();

Console.WriteLine(index);
*/

#endregion

#region FirstOrDefault
/*
List<int> ls = new List<int> { 1, 2, 3, 4, 5, 6 };
int num = ls.FirstOrDefault();

Console.WriteLine(num);

num = ls.FirstOrDefault(x=>x==7);
Console.WriteLine(num);


num = ls.FirstOrDefault(x=>x%2==0);
Console.WriteLine(num);

*/

#endregion

#region Last
/*
List<int> ls = new List<int> { 1, 2, 3, 4, 5, 6 };

int val = ls.Last();
Console.WriteLine(val); 

val = ls.Last(num=>num%2!=0);
Console.WriteLine(val);

*//*
val = ls.Last(num => num>6); // Invalid Operation Exception
Console.WriteLine(val);*/


#endregion

#region LastOrDefault
/*
List<int> ls = new List<int> { 1, 2, 3, 16, 5, 14 };

int val=ls.LastOrDefault();
Console.WriteLine(val);

val = ls.LastOrDefault(x=>x==0);
Console.WriteLine(val);

val = ls.LastOrDefault(x => x%4==0);
Console.WriteLine(val);
*/



#endregion

#region Single

//List<int> ls = new List<int> { 1, 2, 3, 16, 5, 14 };
///*
//int val = ls.Single();   // InvalidOperationException more than one are match
//Console.WriteLine(val);*/

//ls = new List<int>(){4 };
//int val = ls.Single();
//Console.WriteLine(val);


//ls = new List<int>() { 5 ,3,7,6,9};

//val=ls.Single(x=>x%2==0);
//Console.WriteLine(val);

/*
ls = new List<int>() { 5, 3, 7, 6, 9 };

val = ls.Single(x => x == 0); //// InvalidOperationException
Console.WriteLine(val);*/
#endregion

#region SingleOrDefault

List<int> ls = new List<int>() {1,5,7,2,5,7,5 };
/*
int val = ls.SingleOrDefault();
Console.WriteLine(val);*/

int val =ls.SingleOrDefault(x => x == 0);
Console.WriteLine(val);

ls = new List<int>() { 3};
val = ls.SingleOrDefault();
Console.WriteLine(val);
#endregion
