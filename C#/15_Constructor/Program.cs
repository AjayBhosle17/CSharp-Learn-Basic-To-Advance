
#region Constructor Types
/*
Student obj = new Student() ;  // default
Student obj1 = new Student() { first_Name="Ajay",LastName="Bhosle"} ; //default

Student obj2= new Student( "Ajay","Bhosle"); //
Student obj3 = new Student(obj2);

*/
#endregion

Student s=new Student();
s.FullPrintName();

Student s1=new Student("Ajay" ,"Bhosle");
s1.FullPrintName();

Student s2 = new Student() { firstName = "Vivek", lastName = "Ingale" };
s2.firstName = "Samir";
s2.lastName = "Shaikh";
s2.FullPrintName();

Student s3 = new Student(s2);
s3.FullPrintName();