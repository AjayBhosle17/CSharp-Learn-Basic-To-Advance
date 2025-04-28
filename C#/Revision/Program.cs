
using Revision;
using System.Collections;

Demo demo = new Demo();
demo.fun();



ArrayList obj = new ArrayList();
obj.Add(10);
obj.Add("Ajay");
obj.Add(10.5);

foreach (dynamic i in obj)
{
    Console.WriteLine(i);
}


string str = "ajay";
Dictionary<char,int> ch = new Dictionary<char,int>();

for (int i = 0; i < str.Length; i++)
{
    if (ch.ContainsKey(str[i])){
        ch[str[i]]++;
    }
    else
    {
        ch[str[i]] = 1;
    }
}


foreach(KeyValuePair<char,int> item in ch)
{
    Console.WriteLine($"key {item.Key} and value : {item.Value}");
}



Dictionary<int ,string> data= new Dictionary<int ,string>();
data.Add(1, null);
data.Add(2,null);

var data1 = data.Reverse();

foreach(var i in data1)
{
    Console.WriteLine(i);
}



Stack<string> stack = new Stack<string>();

stack.Push("A");
stack.Push("Aj");
stack.Push("Aja");
stack.Push("Ajay");



Queue<int> qu1 = new Queue<int>();

qu1.Enqueue(10);
qu1.Enqueue(20);
qu1.Enqueue(30);
qu1.Enqueue(40);
qu1.Enqueue(50);


while (qu1.Count() > 0)
{
    Console.WriteLine(qu1.Dequeue());
}


Predicate<int> d1 = (x) =>
{
    return x % 2 == 0;
};


Predicate<int> d2 = delegate (int x)
{
    return true;
};

bool x = d2(12);
Console.WriteLine(x);


 static void Fun(){

    Console.WriteLine("Hii");
}

Action<string> x12 =(string x)=>
{
    Console.WriteLine("Helo");
};



Demo obj4 = new Demo();
Console.WriteLine(obj4.fun1());

int age = 20;

string Demo = Extension.CheckAgeVote(age);

Console.WriteLine(Demo);


Extension.fun();


Console.ReadLine();