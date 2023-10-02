// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.

string[] CreateArrayRndStr(int size, int maxLen)
{
    Random rnd = new Random();
    string[] arr = new string[size];
    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    for (int i = 0; i < size; i++)
    {
        int strLen = rnd.Next(1, maxLen + 1); // generating string length randomly
        arr[i] = new string(Enumerable.Repeat(chars, strLen).Select(s => s[rnd.Next(s.Length)]).ToArray());
    }
    return arr;
}

void PrintArray(string[] arr)
{
    Console.WriteLine();
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

string[] FilterArrayByLength(string[] arr, int maxLength)
{
    var filteredList = new List<string>();
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= maxLength)
            filteredList.Add(arr[i]);
    }
    return filteredList.ToArray();
}

var stringsArr = CreateArrayRndStr(20, 5);
PrintArray(stringsArr);
var filteredStringsArr = FilterArrayByLength(stringsArr, 3);
PrintArray(filteredStringsArr);