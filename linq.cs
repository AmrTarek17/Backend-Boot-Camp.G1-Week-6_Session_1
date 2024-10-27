// 1
// Query1: Display numbers without any repeated Data and sorted

List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };

// Query to remove duplicates and sort the numbers
var query1 = numbers.Distinct().OrderBy(n => n);

foreach (var num in query1)
{
    Console.WriteLine(num);
}

// Query2: using Query1  result and show each number and it’s multiplication
// Query2: Display each number and its multiplication
foreach (var num in query1)
{
    Console.WriteLine($"Number: {num}, Multiplication: {num * num}");
}

// 2 

string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

// Query1: Select names with length equal to 3
var query1 = names.Where(name => name.Length == 3);

foreach (var name in query1)
{
    Console.WriteLine(name);
}


// Query2: Select names containing "a" or "A" and sort them by length
var query2 = names
    .Where(name => name.IndexOf("a", StringComparison.OrdinalIgnoreCase) >= 0)
    .OrderBy(name => name.Length);

foreach (var name in query2)
{
    Console.WriteLine(name);
}


// Query3: Display the first 2 names
var query3 = names.Take(2);

foreach (var name in query3)
{
    Console.WriteLine(name);
}
