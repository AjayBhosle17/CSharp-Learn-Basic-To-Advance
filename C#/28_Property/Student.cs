#region NOrmal Access members public
/*public class Student {

    public int rollNo;
    public string name;
    public static int passmark = 40;

}*/
#endregion

#region NOrmal Access members private
/*
public class Student { 

    private int id;
    private string name;
    private int passmark = 40;
}
*/
#endregion

#region getter and setter
/*
public class Student { 

    private int rollNo;
    private String name;

    public void setRollNO(int rn) {

        if (rn > 0)
        {

            rollNo = rn;
        }
        else {

            Console.WriteLine("Roll no can not be negative");
        }
    }


    public int getRollNo() { 
        return rollNo;
    }

    public void setName(string name)
    {
            this.name= name;
            
    }



    public string getName()
    {
        return string.IsNullOrWhiteSpace(name)?"NO Name":name;
    }

}*/

#endregion

#region Property
public class Student { 

    private int _rollNO;
    private String _name;
    private int passmark = 40;

    public int RollNO
    {
        get {

            return _rollNO;
        }

        set {

            if (value > 0)
            {

                _rollNO = value;
            }
            else {

                Console.WriteLine("value is negative");
            }

        }
        
    }

    public int age { get; set;}


}

#endregion Property