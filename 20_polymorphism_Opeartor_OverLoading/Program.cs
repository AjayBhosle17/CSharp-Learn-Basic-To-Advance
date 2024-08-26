
int a = 10;
int b = a;

int c = a + b;

Console.WriteLine($"C value is : {c}");


string firstName = "Ajay";
string lastName = "Bhosle";

string fullName = firstName + lastName;

Console.WriteLine($"fullName: {fullName}");


Calculator obj = new Calculator() { Number1=10,Number2=20};
Calculator obj1 = new Calculator() { Number1 = 10, Number2 = 20 };


Calculator obj3 = obj + obj1;  // Operator + OverLoad
Console.WriteLine($"Number1 = {obj3.Number1} , Number2 = {obj3.Number2}");


// direct add without overLoading

Calculator obj4 = new Calculator() { Number1 = obj.Number1 + obj1.Number1 };
Console.WriteLine(obj4.Number1);

Console.WriteLine();




// == equal operator OverLoading
/*
if (obj == obj1)
{

    Console.WriteLine("Equal");

}
else
{

    Console.WriteLine("Not Equal");
}*/


string name1 = "Ajay";
string name2 = "Ajay";

if (name1 == name2)
{

    Console.WriteLine("Equal");
}
else {

    Console.WriteLine("Not Equal");
}

/*
Student student1 = new Student() { firstName = "Ajay" ,lastName = "Bhosle"};*/

Student student1 = new Student() ;
student1.firstName = "Ajay";
student1.lastName = "Bhosle";

Student student3 = student1;  // equal 

Student student2 = new Student();
student2.firstName = "Ajay";
student2.lastName = "Bhosle";


if (student1 == student2)   // == operator overload
{

    Console.WriteLine("Equal");               

}
else {

    Console.WriteLine("Not Equal");
}

// Substraction overload

substrction obj5 = new substrction();

obj5.num1 = 20;
obj5.num2 = 0;



substrction obj6 = new substrction();

obj6.num1 = 20;
obj6.num2 = 10;


substrction obj7 = obj5 - obj6;

Console.WriteLine($"num1={obj7.num1} num2 = {obj7.num2}");





