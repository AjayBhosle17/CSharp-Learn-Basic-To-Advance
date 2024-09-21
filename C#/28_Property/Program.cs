
using System.Xml.Linq;

#region NOrmal Access members public
/*
Student obj = new Student();
obj.rollNo = 17;
obj.name = "Ajay Bhosle";

Console.WriteLine($"rollNO: {obj.rollNo} name: {obj.name} passmark: {Student.passmark}");*/
#endregion


#region NOrmal Access members private
/*
Student obj = new Student();
//obj.rollNO=17;  error
*/
#endregion

#region geter and seeter
/*
Student obj=new Student();
obj.setRollNO(17);
Console.WriteLine($"get Rollno: {obj.getRollNo()}");
obj.setName("Ajay Bhosle");
Console.WriteLine($"get name : {obj.getName()}");
*/
#endregion

#region property

Student obj = new Student();
obj.RollNO =-10;

Console.WriteLine($"RollNO: {obj.RollNO}");
#endregion