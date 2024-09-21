List<int> numbers = new List<int> { 1, 2, 3 ,4,5,6,7,8,9};


foreach (var number in numbers) {

    Console.WriteLine(number);
}

Console.WriteLine("\nOperation on List");

foreach (int num in Even(numbers)) { 

    Console.WriteLine(num);
}
/*
static List<int> Even(List<int> number) {   

    List<int> result = new List<int>();

    foreach (int num in number) {

        if (num % 2 == 0)
        {
            result.Add(num);
        }
    }
    return result;

}*/

static IEnumerable<int> Even(List<int> number) {

    foreach (var item in number) {

        if (item % 2 == 0)
        {
            yield return item;
        }
    }
}

Console.WriteLine("\n");

foreach(int x in getNumbers()) { 

    Console.WriteLine(x);

}

static IEnumerable<int> getNumbers() {

    yield return 1;
    yield return 2;
    yield return 3;
    yield return 4;
}