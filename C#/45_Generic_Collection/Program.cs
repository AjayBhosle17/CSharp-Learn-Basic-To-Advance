
// Generic
using System.Collections.Generic;

/* *********************************************************************** */
/* *********************************************************************** */

#region List<>
/*
using System.Collections.Generic;

List<int> list = new List<int>();

list.Add(0);
list.Add(1);
list.Add(2);

list.Add(3);
list.RemoveRange(2,2);
//list.Remove(2);
//list.RemoveAt(2);

for (int i = 0; i < list.Count; i++) { 

    Console.WriteLine(list[i]);
}

list.Insert(2,30);

Console.WriteLine($"\nCurrent Count is : {list.Count}\n");
for (int i = 0; i < list.Count; i++)
{

    Console.WriteLine(list[i]);
}

Console.WriteLine($"\nCurrent Count is : {list.Count}\n");

ICollection<int> collection = new List<int>() { 

    5,10,15
};
Console.WriteLine("\nInsertRange:   public void InsertRange(int index, IEnumerable<T> collection)\r\n");
list.InsertRange(0,collection);


Console.WriteLine($"\nCurrent Count is : {list.Count}\n");

for (int i = 0; i < list.Count; i++)
{

    Console.WriteLine(list[i]);
}

Console.WriteLine("\nRemoveRange:  public void RemoveRange(int index, int count)\r\n");
list.RemoveRange(3,2);

Console.WriteLine($"\nCurrent Count is : {list.Count}\n");

foreach (int item in list) { 

    Console.WriteLine(item);
}

Console.WriteLine("\nRemoveAll: public int RemoveAll(Predicate<T> match) ");
list.RemoveAll(n=>n%2==0);


foreach (int item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine("IndexOf :public int IndexOf(T item)\r\n");
int index= list.IndexOf(1);
Console.WriteLine($"Found At index : {index}");

Console.WriteLine("Contains: public bool Contains(T item)");



if (list.Contains(1)) {

    Console.WriteLine("Present");
}
else
{

    Console.WriteLine("Not Presnt");

}
Console.WriteLine("FindIndex: public int FindIndex(Predicate<T> match)\r\n");
list.Insert(0,2);
int data = list.FindIndex(n=>n%2!=0);
Console.WriteLine(data);

foreach (int item in list)
{
    Console.WriteLine(item);
}

list.Add(13);
list.Add(20);
Console.WriteLine($"FindLast: public T? FindLast(Predicate<T> match)");

int last = list.FindLast(n=>n%2!=0);
Console.WriteLine(last);

foreach (int item in list)
{
    Console.WriteLine(item);
}
List<int> list = new List<int>();
list.Add(10);
list.Add(20);
list.Add(30);
list.Add(10);


foreach (int item in list) { 

    Console.WriteLine(item);
}

list.Reverse();
Console.WriteLine("\nReverse");
foreach (int item in list)
{

    Console.WriteLine(item);
}
Console.WriteLine("\nDistinct Element: it is method of IEnumerable ");
IEnumerable<int> distn=list.Distinct();

foreach (var item in distn)
{
    Console.WriteLine(item);
}
List<string> list = new List<string>();
list.Add("z");
list.Add("a");

list.Sort();
foreach (string str in list) { 

    Console.WriteLine(str);
}
*/
#endregion

/* *********************************************************************** */
/* *********************************************************************** */

#region Dictionary<>
/*Dictionary<int,string> dict = new Dictionary<int,string>();

dict.Add(1,"Ajay");
dict.Add(2, "Vijay");
dict.Add(3, "Arpita");

//foreach(KeyValuePair<int,string> item in dict)
//foreach (var item in dict)
//foreach (Object item in dict) // error
foreach (dynamic item in dict)

{
    Console.WriteLine($"key: {item.Key} Value: {item.Value.ToUpper()}");
}

string var1 = dict[2];
Console.WriteLine(var1);


bool x = dict.ContainsKey(2);
Console.WriteLine(x);*/

#endregion
/* *********************************************************************** */
/* *********************************************************************** */

#region LinkedList

/*LinkedList<string> list = new LinkedList<string>();

list.AddLast("Ajay");
list.AddLast("Vijay");
foreach (var item in list) { 

    Console.WriteLine(item);
}

list.AddFirst("Om");
Console.WriteLine("Addfirst: ");
foreach (var item in list)
{

    Console.WriteLine(item);
}
*/

#endregion

/* *********************************************************************** */
/* *********************************************************************** */

#region Stack
/*
Stack<string> history = new Stack<string>();
history.Push("google.com");
history.Push("google.com/search/csharp");
history.Push("csharpcorner.com");

Console.WriteLine("Stack: ");
foreach (string item in history)
{

    Console.WriteLine(item);

}

string val = history.Pop();

Console.WriteLine($"\nPopped: {val}");

foreach (string item in history) { 

    Console.WriteLine(item);

}

Console.WriteLine("Peek: ");
val = history.Peek();
Console.WriteLine($"\nPeek is : {val}");

foreach (string item in history)
{

    Console.WriteLine(item);

}
bool result = history.Contains("Ajay");
Console.WriteLine(result);
*/
#endregion


/* *********************************************************************** */
/* *********************************************************************** */


#region Queue

Queue<int> token = new Queue<int>();
token.Enqueue(1);
token.Enqueue(2);
token.Enqueue(3);
token.Enqueue(4);
Console.WriteLine("Queue: ");

foreach (var item in token) { 

    Console.WriteLine(item);
}


var val = token.Dequeue();
Console.WriteLine($"\nToken Dequeue: {val}\n");
Console.WriteLine("Remaining Tokens: ");
foreach (var item in token)
{

    Console.WriteLine(item);
}

val = token.Peek();
Console.WriteLine("Peek token");
Console.WriteLine($"Peek: {val}");

#endregion

/* *********************************************************************** */
/* *********************************************************************** */

#region SortedSet
Console.WriteLine("\nSortedSet: \n");
SortedSet<int> hs = new SortedSet<int>();

hs.Add(1);
hs.Add(1);

foreach (var item in hs) { 

    Console.WriteLine(item);
}

Console.WriteLine($"Count is : {hs.Count}");

#endregion
/* *********************************************************************** */
/* *********************************************************************** */

#region Tuple

Console.WriteLine("\nTuple: \n");

Tuple<int, string,string> tuple = new Tuple<int, string,string>(1,"Ajay","Male");

Console.WriteLine(tuple.Item1);  // less readability
Console.WriteLine(tuple.Item2);

Tuple<int, int, int, int, int, int, int, Tuple<int, string, string>> tp1 = new Tuple<int, int, int, int, int, int, int, Tuple<int, string, string>>(1,2,3,4,5,6,7,tuple);

Console.WriteLine(tp1.Rest.Item3);
Console.WriteLine();



// Multiple values return

Console.WriteLine("Multiple Value Return");

var result2 = getvalues();
Console.WriteLine(result2.Item1);
Console.WriteLine(result2.Item2);
Console.WriteLine(result2.Item3);

static Tuple<int,string,string> getvalues() {

    return new Tuple<int,string,string>(1,"Ajay","Male");
}

#endregion
/* *********************************************************************** */
/* *********************************************************************** */