// See https://aka.ms/new-console-template for more information

static void WorkingWithStrings() {
    var names = new List<string>() { "Johnson", "Xhaiden", "Blessing" };
    Console.WriteLine();
    names.Add("Karale");
    names.Add("Sira");
    names.Add("Wiwuga");
    Console.WriteLine($"There are {names.Count} names in the list.");
    Console.WriteLine("------------- BEFORE SORTING ----------------");
    foreach (var name in names)
    {
        Console.WriteLine($"Hello, {name.ToUpper()}");
    }

    Console.WriteLine($"My name is {names[3]} {names[4]} {names[5]}!");

    var index = names.IndexOf("Johnson");
    if (index != -1)
    {
        Console.WriteLine($"{names[index]} successfully removed!");
        names.RemoveAt(index);
        Console.WriteLine($"There are now {names.Count} names left in the list after the removal!");
    }
    else
    {
        Console.WriteLine("Name not Found!");
    }

    Console.WriteLine("------------- AFTER SORTING ----------------");
    names.Sort();
    names.Reverse();

    foreach (var name in names)
    {
        Console.WriteLine($"New here, {name.ToUpper()}");
    }
}

// WorkingWithStrings();

var fibonacciNumbers = new List<int>() {1, 1};



for(int i = 2; i < 20; i++)
{
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
    fibonacciNumbers.Add(previous + previous2);
}


foreach(var item in fibonacciNumbers)
{
    Console.WriteLine(item);
}