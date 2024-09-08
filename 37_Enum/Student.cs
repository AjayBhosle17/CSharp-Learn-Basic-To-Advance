
using System.Reflection;

/*// Using Integral Constant
public class Student
{

    public int rollNo { get; set; }
    public string name { get; set; }
    public int Gender { get; set; }
}*/

public class Student
{

    public int rollNo { get; set; }
    public string name { get; set; }
    public GenderInp Gender { get; set; }
    public Marks subject { get; set; }
   
}
public enum GenderInp
{
    male, 
   female
}

public enum Marks{ 

    Marathi = 76,
    Hindi = 77,
    English = 78,
    Math = 97,
    Science = 93,
    Social = 98
}


public class Alphabet { 

    public string name { get; set; }
    public Vowels vowel { get; set; }

    public charct ch;
}

public enum Vowels
{
    a=1,e,i,o=5,u=8

}

public enum charct:byte { 

}