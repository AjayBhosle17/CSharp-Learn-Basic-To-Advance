

#region Single Cast

//Customer obj = new Customer();

//obj.printA();

//2. instance create delegate

//printDelgate pd1 = new printDelgate(obj.printA);
/*printDelgate pd2 = new printDelgate(obj.printB);

//3 . Invoke
pd2();
pd1();


printDelgate pd3 = new printDelgate(obj.printC);  // singale delegate point to single method so it is a single cast
pd3();

//printDelgate pd4 = new printDelgate(obj.PrintD); // wrong return type so firstly string return type delegate declare

printDel pd5 = new printDel(obj.printD);

string str1 = pd5();

Console.WriteLine(str1);
*/


// 2nd way to create instance
/*
printDelgate pd6 = obj.printB;
pd6();

printDel pd7 = obj.printD;

string str2 = pd7();
Console.WriteLine(str2);*/

#endregion


#region MultiCast
/*
Customer obj = new Customer();

printDelgate pd1 = obj.printA;
printDelgate pd2 = obj.printB;
printDelgate pd3 = obj.printC;

printDelgate pd = pd1 + pd2 + pd3;

pd();

Console.WriteLine("De register some delegate methods");
printDelgate pd8 = pd1 + pd2 + pd3 - pd1;

pd8();*/



// also use += & -=

/*
printDelgate pd99 = obj.printA;
pd99 += obj.printB;
pd99 += obj.printC;
// pd99 +=obj.printD;   // error different signature
pd99();
*/

Customer obj = new Customer();
Console.WriteLine("\n\n\n\n");

printDel pd11 = obj.print1;
pd11 += obj.print2;
pd11 += obj.print3;

//string str4= pd11();  // here only last called store not all that problem solve by invokation list

//Console.WriteLine(str4);


Console.WriteLine("\nUsing Invocation List");

Delegate[] delegates = pd11.GetInvocationList();

foreach (Delegate d in delegates)
{

    string s = d.DynamicInvoke().ToString();
    Console.WriteLine(s);
}



#endregion


#region Anonyms

Console.WriteLine("\nAnonyms");

// Anonyms


printDelgate d1 = delegate ()
{

    Console.WriteLine("Anonyms Method Called");
};

d1();

fullName d2 = delegate (string firstName, string lastName)
{
    Console.WriteLine($"FullName: {firstName} {lastName}");

};
d2("Ajay", "Bhosle");

Addition d3 = delegate (int num1, int num2)
{

    return num1 + num2;
};

int sum = d3(20, 10);
Console.WriteLine($"Sum is a: {sum}");

#endregion



#region Method as a Parameter


Customer obj8 = new Customer();

printDelgate pd88 = obj.printB;
obj.printA(pd88);

#endregion



