// Operators
/*
1. Arithematic (+,-,*,/,%)
2. Compound    (+= ,-=,*=,/=,%=)
3. Assignment  (=)
4. Comparision (!=,== , >= , <= ,>, <)
5. Logical      (&& , ||)
6. Incriment / decrement (++ , --)
7. Ternary Operatot (?:)*/

int x = 10;
int y = 20;

Console.WriteLine(x + y);

x += 10;

Console.WriteLine(x);


bool z = 10 % 5 == 0;

Console.WriteLine(z);


int a = 1;
int b = 2;

int c = ++a + a++ + a++;
//2 + 2 + 3
Console.WriteLine($"value of A is {a} and C is {c}");

bool data = true && false;
Console.WriteLine(data);


bool ab = x < y;
Console.WriteLine(ab);

Console.ReadLine();



