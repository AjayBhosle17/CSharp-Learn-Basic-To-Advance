/*
// Using Integeral Constant
Student obj = new Student();
obj.rollNo = 17;
obj.name = "Ajay Bhosle";
obj.Gender = 1;

Console.WriteLine($"rollno {obj.rollNo} name : {obj.name}  gender: {getGender(obj.Gender)}");
String getGender(int n) {
    switch (n) {

        case 1:
            return "male";
        case 2:
            return "Female";
        default:
            return "Wrong Input";

    }
}

*/


// Using Enum

Student obj = new Student();
obj.rollNo = 10;
obj.name = "Ajay";
obj.Gender = GenderInp.male;

Console.WriteLine($"rollno {obj.rollNo} name : {obj.name}  gender: {obj.Gender}");


Student obj2 =new Student() { rollNo=19,name="Anjali",Gender=GenderInp.female};
Console.WriteLine($"rollno {obj2.rollNo} name : {obj2.name}  gender: {obj2.Gender}");


GenderInp[] obj3 = new GenderInp[3];


Type t = Enum.GetUnderlyingType(typeof(GenderInp));
Console.WriteLine($"Underlying type name : {t.Name}");

string[] genderlist = Enum.GetNames(typeof(GenderInp));

foreach(string item in genderlist)
{
    Console.WriteLine(item);
    
}

// retrive values

int[] values1 = (int[])Enum.GetValues(typeof(GenderInp));
foreach (var value in values1)
{
    Console.Write($"{value}\t\t");
}

// find using index
string name = genderlist[0];
Console.WriteLine(name);

Student obj7 = new Student() { name = "Vijay" , rollNo = 12,subject=Marks.Marathi};

Console.WriteLine($"marks : {obj7.subject}");

string[] marks = Enum.GetNames(typeof(Marks));


foreach (string item in marks) { 

    Console.WriteLine(item);
}

int[] values = (int[])Enum.GetValues(typeof(Marks));

foreach (var value in values)
{
    Console.Write($"{value}\t\t");
}




Type t1 = Enum.GetUnderlyingType(typeof(Vowels));
Console.WriteLine($"Hiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii{t1}");


Alphabet obj5 = new Alphabet();
obj5.name = "Vowels";
obj5.vowel = Vowels.a;

Console.WriteLine(obj5.vowel);

string[] arr = Enum.GetNames(typeof(Vowels));
foreach (string item in arr) { 

    Console.WriteLine(item);
}

int[] values3 = (int[]) Enum.GetValues(typeof(Vowels));

foreach (int var in values3) { 

    Console.WriteLine(var);
}

Type t4 = Enum.GetUnderlyingType(typeof(charct));

Console.WriteLine(t4);


