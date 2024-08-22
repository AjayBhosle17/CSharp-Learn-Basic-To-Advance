
// Inheritance Types

#region Single level Inheritance
/*IPL obj = new IPL();
obj.display();

// IPL obj1 = new BCCI(); Error

BCCI obj2 = new IPL();
((IPL)obj2).display(); // when u hide in BCCI display method


BCCI obj3 = new BCCI();
obj3 .display();
*/
#endregion

#region Multi_Level Inheritance
/*
Child obj = new Child();
obj.Property();
obj.AddProperty();
obj.AddBothProperty();

Parent obj1 = new Child();
obj1.Property();
obj1.AddProperty();
// obj1.AddBothProperty(); // error
((Child)obj1).AddBothProperty();

Parent obj2=new Parent();
obj2.Property();
obj2.AddProperty();

*/

#endregion

#region Hierachical Inheritance

Student1 obj1 = new Student1();
obj1.details1();
obj1.details();


Student2 obj2 = new Student2();
obj2.details2();
obj2.details();


Company obj3 = new Student1();
//obj3.details1(); // error
obj3.details();
#endregion


// hybrid inhritance not support
// Multiple inheritance also Not Support