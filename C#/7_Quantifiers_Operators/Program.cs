// Quantifiers
/*
1.All
2.Any
3.Contains
*/

#region All
/*
List<int> ls = new List<int> { 1, 2, 3 ,4,5,6};

bool ans = ls.All(x=>x!=0);

Console.WriteLine(ans);


ans = ls.All(x => x % 2 == 0);
Console.WriteLine(ans);*/
#endregion

#region Any
/*
List<int> ls = new List<int> { 1, 2, 3, 4, 5, 6 };

bool ans = ls.Any(x=>x%2==0);
Console.WriteLine(ans);

ans = ls.Any(x => x == 0);
Console.WriteLine(ans);
*/

#endregion


#region Contains

List<int> ls = new List<int> { 1, 2, 3, 4, 5, 6 };

bool ans = ls.Contains(12);  //false

Console.WriteLine(ans);

ans = ls.Contains(5);

Console.WriteLine(ans);




List<Student> obj = new List<Student>()
{
    new Student(){ firstName="Ajay" ,lastName="Bhosle"},
    new Student(){ firstName="Vijay" ,lastName="Bhosle"},
    new Student(){ firstName="Om" ,lastName="Bhosle"},
    new Student(){ firstName="Jay" ,lastName="Bhosle"},
};

Student obj1 = new Student() { firstName ="ijay" ,lastName="Bhosle"};

ans=obj.Contains(obj1,new StudentCompare());

Console.WriteLine(ans);
#endregion