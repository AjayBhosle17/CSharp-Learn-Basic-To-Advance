
// Aggregation_Operators
/*
1.Aggregate
2.Max
3.Min
4.Avg
5.sum
6.Count
7.LongCount*/

#region Aggregate
/*List<int> ls = new List<int> { 1, 2, 3,4};

int sum= ls.Aggregate((i,j)=>i+j);
Console.WriteLine($"Aggregate of Sum: {sum}");

int fact = ls.Aggregate((i,j)=>i*j);

Console.WriteLine($"Aggregate of facto: {fact}");

List<String> ls1 = new List<string>() { "Ajay", "Bhosle" };

string concat = ls1.Aggregate((i,j)=>i + " " + j);
Console.WriteLine($"Concat: {concat}");
*/
#endregion

#region Avg
/*
List<int> ls = new List<int>() { 1,2,5,4,8,1};

double avg = ls.Average();

Console.WriteLine(avg);

List<String> ls1 = new List<string>() { "Ajay", "Bhosle" };

double avg1 = ls1.Average(s=>s.Length);

Console.WriteLine(avg1);*/

#endregion

#region Count
/*List<int> ls = new List<int>() { 1, 2, 5, 4, 8, 1 };
int cnt = ls.Count();

Console.WriteLine($"Count is : {cnt}");

cnt = ls.Count(num=>num%2==0);
Console.WriteLine($"Count Of Even No is : {cnt}");

int x = ls.Where(num=>num%2==0).Count();
Console.WriteLine(x);*/

#endregion

#region LongCount
/*

List<String> ls1 = new List<string>() { "Ajay", "Bhosle" };
int x = ls1.Count();
Console.WriteLine(x);



List<int> ls = new List<int>() { 1, 2, 5, 4, 8, 1 };

long count=ls.LongCount();
Console.WriteLine($"Count is : {count}");

count = ls.LongCount(num=>num>4);
Console.WriteLine($"Count is : {count}");*/

#endregion

#region sum
/*
List<int> ls = new List<int>() { 1, 2, 5, 4, 8, 1 };
int sum = ls.Sum();

Console.WriteLine($"Sum is : {sum}");
ls.Count(num=>num%2==0);

//ls.Sum(num=>num%2==0);  // error bcoz it return bool

sum=ls.Sum(num=>num%2==0 ? num:0);
Console.WriteLine($"Sum Of Even no : {sum}");*/


#endregion sum

#region max
/*
List<int> ls = new List<int>() { 11, 2, 25, 4,18, 13 };

int max = ls.Max();
Console.WriteLine($"Max no is {max}");

max=ls.Max(num=>num%2==0 ? num : 0);

Console.WriteLine($"Even max: {max}");*/

#endregion

#region min

List<int> ls = new List<int>() { 11, 2, 25, 4, 18, 13 ,1};

int min=ls.Min();
Console.WriteLine($"Minimum element is : {min}");

min=ls.Where(num => num % 2 == 0).Min();
Console.WriteLine($"Even Minimum: {min}");

#endregion