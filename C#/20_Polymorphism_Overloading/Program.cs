Calculator obj = new Calculator();


obj.Print();
int x = 10;

obj.Print(x);

obj.Print(10.4f, 20);

int a = 10;
obj.Print(ref a);

float b = 1.5f;
obj.Print(out b);

float c = obj.sum(10,10.5f);
Console.WriteLine(c);




