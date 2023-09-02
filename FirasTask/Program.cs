string[] masInput = Console.ReadLine().Split(" ");
Console.WriteLine(string.Join(" ", MasChooseItem(masInput)));

string[] MasChooseItem(string[] mas)
{
    int index = 0;
    int sizeMasItem = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i].Length <= 3)
        {
            sizeMasItem++;
        }
    }
    string[] masItem = new string[sizeMasItem];
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i].Length <= 3)
        {
            masItem[index] = mas[i];
            index++;
        }
    }
    return masItem;
}

/*Короткое решение
string[] result = Console.ReadLine().Split(" ").Where(x => x.Length <= 3).ToArray();
Console.WriteLine(string.Join(" ", result));
*/