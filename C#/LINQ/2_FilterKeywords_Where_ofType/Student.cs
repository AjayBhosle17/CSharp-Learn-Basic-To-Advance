public class Student {

    public int RollNo { get; set; }
    public string Name { get; set; }

    public string Gender { get; set; }

}

public class Car {

    public string name { get; set;}

}

public class Audi: Car
{
    public Audi() {

        name = "Audi";
    }
}

public class Bugati : Car {

    public Bugati() {

        name = "Bugati";
    }
}

public class BMW : Car
{
    public BMW() {

        name = "BMW";
    }
}
