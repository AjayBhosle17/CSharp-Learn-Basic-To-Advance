
#region is keyword
/*
Parent obj = new Parent();
obj.printA();

Child obj1 = new Child();
//obj1.printA();


Parent obj2 =new Parent();

//Child obj3 =(Child) obj2;   // type casting //throw exception InvalidcastException
//obj3.printA();   // it will runtime exception
//obj3.printB();

if (obj2 is Child)
{
    Child obj3 = (Child)obj2;
    obj3.printA();
    obj3.printB();
}
else {

    Console.WriteLine("Type is not compatible to cast");
}
*/
#endregion

#region as Keyword

Parent obj = new Parent();

Child obj1 =obj as Child; // it retturn converted object or returns null value

if (obj1 != null)
{

    obj1.printA();
    obj1.printB();
}
else {

    Console.WriteLine("Type COnversion Failed");
}


#endregion