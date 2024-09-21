
Student obj = new Student();
/*printdelegate pd = obj.printC;
pd();

pd = obj.printB;
obj.printA(pd);


Fullname fd = delegate(string firstName , string lastName)
{
    return $"fullName: {firstName} {lastName}";
};

string str1 = fd("Ajay", "Bhosle");
Console.WriteLine(str1);



printdelegate pd2 = obj.printC;
pd2();



printdelegate pd3 = obj.printC;

obj.printA(delegate() {

    Console.WriteLine("He hava Hey kay Ata navin");
});


int x = obj.printOdd(delegate () {

    return 10 / 2;
});

Console.WriteLine(x);*/

obj.printA(delegate () {

    Console.WriteLine("Anonyms Method Called");

});

printdelegate pd3 = obj.printB;
obj.printA(pd3);
