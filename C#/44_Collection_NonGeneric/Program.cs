﻿
// non generic

/* **************************************************************** */

#region ArrayList
/*
using System.Collections;

*//*ArrayList student_Data = new ArrayList();

Console.WriteLine("Add 5 Student");
Console.WriteLine("Enter Names: ");
for (int i = 1; i <= 5; i++) { 

    Console.Write($"Student {i} : ");
    student_Data.Add(Console.ReadLine());

}
*//*
//int[] arr = new int[] { 1,2,3,4};
//string s = string.Join(" ", arr);
//Console.WriteLine(s);
//Console.WriteLine(string.Join(',',student_Data.ToArray()));

//Console.WriteLine(student_Data);

// Add
Console.WriteLine("\nAdd :   public virtual int Add(object? value)\r\n");

ArrayList arrayList = new ArrayList();
arrayList.Add("Ajay");
arrayList.Add("Vijay");
arrayList.Add("Om");



for (int i = 0; i < arrayList.Count; i++) { 

    Console.Write(arrayList[i]);
    Console.WriteLine();
}
//arrayList.Add(10);
*//*foreach (string str in arrayList) {  // InvalidCastException // no type safety
                                           
    Console.WriteLine(str);
}*//*

// multiple Item Add

Console.WriteLine("\nAddRange:   public virtual void AddRange(ICollection c)\r\n ");
ArrayList collection = new ArrayList() { 40,50};

arrayList.AddRange(collection);

string[] array = {"Akash","Vikas" };
arrayList.AddRange(collection);
int k = 0;
foreach (var i in arrayList) {
    
    Console.WriteLine($"index: {k++}: {i}");
}



// count
Console.WriteLine($"arrayList.Count     public virtual int Count => _size;\r\n");
Console.WriteLine($"Count is : {arrayList.Count}");
//Insert
Console.WriteLine("\nInsert:   public virtual void Insert(int index, object? value)\r\n ");
arrayList.Insert(3,"Vikul");
k = 0;
foreach (var i in arrayList)
{
    
    Console.WriteLine($"index: {k++}: {i}");
}

Console.WriteLine("\nRemove:      public virtual void Remove(object? obj)\r\n ");
arrayList.Remove("Ajay");
k = 0;
foreach (var i in arrayList)
{

    Console.WriteLine($"index: {k++}: {i}");
}

Console.WriteLine("\nRemoveAt   public virtual void RemoveAt(int index)\r\n");
arrayList.RemoveAt(5);
k = 0;
foreach(var i in arrayList)
{

    Console.WriteLine($"index: {k++}: {i}");
}

Console.WriteLine("\nRemoveRange :   public virtual void RemoveRange(int index, int count)\r\n");
arrayList.RemoveRange(2,3);
k = 0;
foreach (var i in arrayList)
{

    Console.WriteLine($"index: {k++}: {i}");
}
arrayList.RemoveAt(2);

// Add
Console.WriteLine("\nAdd: ");
arrayList.Add("Akshay");
arrayList.Add("Sameer");
arrayList.Add("Ajay");
k = 0;
foreach (var i in arrayList)
{

    Console.WriteLine($"index: {k++}: {i}");
    
}

Console.WriteLine("\nContains      public virtual bool Contains(object? item) => Array.IndexOf(_items, item, 0, _size) >= 0;\r\n");


if (arrayList.Contains("AA"))
{
    Console.WriteLine("Found");

}
else
{
    Console.WriteLine("Not Found");
}

ArrayList new1 = new ArrayList();
new1.AddRange(arrayList);

k = 0;
foreach (var i in new1)
{

    Console.WriteLine($"index: {k++}: {i}");

}


Console.WriteLine("\nIndexOf    public virtual int IndexOf(object? value)\r\n");

int index = arrayList.IndexOf("Ajay");
Console.WriteLine($"Found At Index {index}");
arrayList.Insert(5,"Vijay");
*//*
int index1 = arrayList.IndexOf("Vijay", 0, 2);
Console.WriteLine($"Found At Index {index1}");
Console.WriteLine();*//*

Console.WriteLine("\nPrevious Add Data");
k = 0;
foreach (var i in arrayList)
{

    Console.WriteLine($"index: {k++}: {i}");

}
Console.WriteLine("\ninsertRange     public virtual void InsertRange(int index, ICollection c)\r\n");
ArrayList new2 = new ArrayList();
new2.AddRange(arrayList);
arrayList.InsertRange(2,new2);
k = 0;

foreach (var i in arrayList)
{

    Console.WriteLine($"index: {k++}: {i}");

}

Console.WriteLine("\nLastIndex:  public virtual int LastIndexOf(object? value)\r\n");

int lastindex = arrayList.LastIndexOf("Vijay");
Console.WriteLine($"Last Index of Vijay is : {lastindex}");

lastindex = arrayList.LastIndexOf("Ajay");
Console.WriteLine($"Last Index of Ajay is : {lastindex}");


Console.WriteLine("\nReverse:  public virtual void Reverse()\r\n ");
arrayList.Reverse();
k = 0;

foreach (var i in arrayList)
{

    Console.WriteLine($"index: {k++}: {i}");

}

Console.WriteLine("\nSort   public virtual void Sort()\r\n");
arrayList.Sort();
k = 0;

foreach (var i in arrayList)
{

    Console.WriteLine($"index: {k++}: {i}");

}

Console.WriteLine($"\nCapacity: {arrayList.Capacity} ");

arrayList.Capacity = 20;

Console.WriteLine($"\nCapacity: {arrayList.Capacity} ");


Console.WriteLine($"\nI want to find at 3 index =  {arrayList[3]}");

Console.WriteLine($"\nClear:    public override void Clear()\r\n");
arrayList.Clear();

Console.WriteLine("Clear List\n");
*/
#endregion

/* **************************************************************** */
/* **************************************************************** */

#region HashTable

//key value pair

using System.Collections;
using System.Security.Cryptography;

Hashtable hashtable = new Hashtable();

Console.WriteLine("\nHashMap Add():   public virtual void Add(object key, object? value)\r\n  ");

hashtable.Add(1,"Ajay");
hashtable.Add(2, "Vijay");
hashtable.Add(3, "Om");
hashtable.Add(-4, "Om");

foreach (DictionaryEntry item in hashtable) { 

    Console.WriteLine($"Key : {item.Key}  Value : {item.Value}");
}

Console.WriteLine("\nRemove : public virtual void Remove(object key)\r\n");
hashtable.Remove(3);
foreach (DictionaryEntry item in hashtable)
{

    Console.WriteLine($"Key : {item.Key}  Value : {item.Value}");
}

Console.WriteLine($"\nCount: {hashtable.Count}");


// hashtable.Add(3,"Ajay");  // error


if (hashtable.ContainsKey(2))
{

    Console.WriteLine("Present");
}
else {

    Console.WriteLine("Not Present");
}


var val = hashtable[1];
Console.WriteLine(val);


ArrayList arrayList = new ArrayList();

arrayList.Add("Ajay");
arrayList.Add("Vijay");

Console.WriteLine("\nClear : ");
hashtable.Clear();
Console.WriteLine("Clear Table");



/*
// Question 1 
// Find Frequency


Dictionary<string,int> obj = new Dictionary<string,int>();

foreach (DictionaryEntry item in hashtable) {

    string str = item.Value.ToString();
    if (obj.ContainsKey(str))
    {

        obj[str]++;
    }
    else { 
    
        obj[str]=1;
    }
}


foreach (var item in obj) {

    Console.WriteLine($"{item.Key}  = {item.Value}");
}*





/* **************************************************************** */
/* **************************************************************** */
#endregion

/* **************************************************************** */
/* **************************************************************** */

#region Stack

//using System.Collections;


Stack History = new Stack();

Console.WriteLine("\nPush :    public virtual void Push(object? obj)\r\n");
History.Push("Tab Click");
History.Push("Google.com search");
History.Push("Youtube Search");

foreach (var item in History) { 

    Console.WriteLine(item);
}

Console.WriteLine("\nPop:   public virtual object? Pop()\r\n ");

var pop=History.Pop();
Console.WriteLine($"Poped : {pop}");

Console.WriteLine("\nPeek: public virtual object? Peek()\r\n");
var peek = History.Peek();
Console.WriteLine($"Peek is : {peek}\n");

History.Clear();
History.Push(10);

History.Push(20);

History.Push(30);
History.Push("Ajay");

if (History.Contains("Ajay"))
{

     var temp  = History.Pop();
    Console.WriteLine($"{temp} : Popped Sucessfully ");
}
else {

    History.Push("Ajay");
    Console.WriteLine("Push Sucessfully");
}

foreach (var sta in History) { 

    Console.WriteLine(sta);
}
//int pop1 = (int)History.Pop();  //  its not work 

// Console.WriteLine(pop1);


#endregion Stack


/* **************************************************************** */
/* **************************************************************** */

#region Queue


Queue token = new Queue();

Console.WriteLine("\nEnqueue:  public virtual void Enqueue(object? obj)\r\n ");
token.Enqueue(1);
token.Enqueue(2);
token.Enqueue(3);
Console.WriteLine("Items Are: ");
foreach (var item in token) { 

    Console.WriteLine(item);
}

Console.WriteLine("\nDequeue :  public virtual object? Dequeue()\r\n ");

var tk=token.Dequeue();
Console.WriteLine($"Token Dequeue is : {tk}");

Console.WriteLine("\nNow Items Are: ");
foreach (var item in token)
{

    Console.WriteLine(item);
}

Console.WriteLine($"Token Count is : {token.Count}");


Console.WriteLine($"Peek : public virtual object? Peek()\r\n");  
tk=token.Peek();
Console.WriteLine($"Peek Token is {tk}");

Console.WriteLine("\nClear() tokens");
token.Clear();
Console.WriteLine("Empty Token");





#endregion Queue



/* **************************************************************** */
/* **************************************************************** */