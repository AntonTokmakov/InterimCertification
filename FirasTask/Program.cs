//Короткое решение
string[] result = Console.ReadLine().Split(" ").Where(x => x.Length <= 3).ToArray();
Console.WriteLine(string.Join(" ", result));
