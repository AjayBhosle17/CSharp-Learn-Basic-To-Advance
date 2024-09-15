/*public class Student {

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
}*/


#region indexer

/*
public class Student { 

    private string[] name = new string[5];

    public string this[int index] {

        get { 
        
            return name[index];
        }

        set
        {
            name[index] = value;
        }
    }
}*/

public class Library {

    public string[] books = new string[5];

    public string this[int index]
    {


        get {

            if (books.Length != null && books != null)
            {

                return books[index];
            }
            else {

                Console.WriteLine("Book is not Found");
            }
            return "Book is invalid";
        }
        set
        {
            if (books.Length != null && books != null)
            {

                books[index] = value;
            }
            else
            {

                Console.WriteLine("we have added only five books");
            }
            

        }
    }
 }

#endregion