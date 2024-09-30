
public class Trainer {

    public int id { get; set; }
    public string Name { get; set; }
    public int Experience { get; set; }

    public List<Trainer> getdetails()
    {

        return new List<Trainer>(){

            new Trainer {id =1 ,Name= "Shashi", Experience=4},
            new Trainer {id =2 ,Name= "Vikul", Experience=12},
            new Trainer {id =3 ,Name= "Usha", Experience=6}
        };
    }
}