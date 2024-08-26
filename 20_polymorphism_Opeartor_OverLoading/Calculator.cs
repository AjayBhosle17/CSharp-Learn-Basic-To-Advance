
public class Calculator {

    public int Number1;
    public int Number2;


    public static Calculator operator+(Calculator a, Calculator b){

        Calculator calculator = new Calculator();

        calculator.Number1 = a.Number1 + a.Number2;
        calculator.Number2 = a.Number1 + b.Number2;

        return calculator;  


    }
}


public class Student
{


    public string firstName;
    public string lastName;

    public static bool operator== (Student s1, Student s2){
/*
        if ((s1.firstName != s2.firstName) || s1.lastName != s2.lastName) { 
        
            return false;
        }
*/
        return s1.firstName==s2.firstName && s1.lastName==s2.lastName;
    }

    public static bool operator!= (Student s1, Student s2){

           return s1.firstName != s2.firstName || s1.lastName != s2.lastName;
    }
}


public class substrction { 

    public int num1;
    public int num2;

    public static substrction operator -(substrction sub1 , substrction sub2) { 
    
        substrction s3 = new substrction();

        s3.num1= sub1.num1-sub2.num1;
        s3.num2= sub1.num2-sub2.num2;
        return s3;

    }


}