
Student obj = new Student();
List<Student> ls = obj.getAll();

foreach (Student s in ls) { 

    Console.WriteLine(s);

}

var list1=ls.GroupBy(s=>s.Gender);

foreach (var item in list1) { 

    Console.WriteLine($"Group: {item.Key}");

    foreach (var item1 in item) { 
    
        Console.WriteLine($"Name: {item1.Name} \tGender: {item1.Gender}");
    }
}


var list2 = from i in ls
            group i by i.Salary;

foreach (var i in list2) {

    Console.WriteLine($"Key ={i.Key}");

    foreach (var i2 in i) {

        Console.WriteLine($"Name:{i2.Name}");
    }
}

var list3 = ls.ToLookup(s=>s.Age);

foreach (var i in list3) {

    Console.WriteLine($"Key:{i.Key}");

    foreach (var i2 in i) {
        Console.WriteLine($"name: {i2.Name} Age: {i2.Age}");
    }

    Console.WriteLine();
}
            