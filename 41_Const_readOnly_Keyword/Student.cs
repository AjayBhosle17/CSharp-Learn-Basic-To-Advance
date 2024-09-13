public class Student {

    public int RollNo = 12;
    public string name = "Ajay";

    public static int id = 21;

    //public const int x;  //error first value intialize

    public const int x = 30;

    public readonly int y;

    public Student() {

        y = 30;
       // v = 20;
    }

    public readonly int z=20;
    public static readonly int v;

    static Student() {

        v = 40;
    }


}