
Student obj = new Student();
printdelegate obj1 = obj.printA;
obj1();

obj.printB(obj1);