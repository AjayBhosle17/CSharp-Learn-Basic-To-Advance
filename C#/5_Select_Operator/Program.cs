
#region Select
/*Student obj = new Student();

List<Student> ls1 = obj.getAll();

IEnumerable<string> en1 = ls1.Select(s => s.Name);

foreach(string s in en1) { 

    Console.WriteLine($"Name: {s}");
}

var en2 = ls1.Select(s => new  {Name= s.Name,Sal= s.Salary});
foreach (var item in en2) {

    Console.WriteLine(item);
}


var x = new
{
    Name = "Ajay",
    Last = "Ajju"
};

Console.WriteLine(x.Name);

var en3 = from item in ls1
          select new
          {
              Name = item.Name,Sal= item.Salary
          };


foreach (var item in en3) { 

    Console.WriteLine(item);
}


var en4 = ls1.Select(s => new {

    s.Name,
    Sal = s.Salary,
    s.Age
});


foreach (var item in en4)
{
    Console.WriteLine(item);
}

string namecities = "";
foreach (var item in en4)
{
    namecities += $"{item.Name}:{item.Age} & ";
}
Console.WriteLine(namecities.TrimEnd(' ', '&'));*/



#endregion Select

#region SelectMany

Student obj = new Student();

List<Student> ls1 = obj.getAll();

IEnumerable<List<string>> en2=ls1.Select(s => s.subjects);

foreach (var s in en2) { 
   

    foreach (var item in s) { 
    
        Console.WriteLine(item);
    }


}

IEnumerable<string> ls2 = ls1.SelectMany(s =>s.subjects.Select(sub=>$"{sub} {s.Name}"));


ls1.Sort(Comparison)
foreach (string i in ls2) { 

    Console.WriteLine(i);
}

#endregion



