# **Метод CreateArrayRndStr(int size, int maxLen)**

```
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
````
+ Метод **`CreateArrayRndStr`** принимает два аргумента: *`size`* и *`maxLen`*.
+ Создание нового объекта типа *`Random`* и назначение его переменной *`rnd`*.
+ Создание массива строк *`arr`* длиной *`size`*.
+ *`chars`* объявляется как константа, содержащая все буквы английского алфавита и цифры от 0 до 9.
+ Цикл *`for`* выполняется *`size`* раз.
+ В каждой итерации генерируется случайное число от 1 до *`maxLen+1`* и назначается переменной *`strLen`*.
+ Заполнение *`i`*-того элемента массива *`arr`* случайной строкой длиной *`strLen`* состоящей из символов *`chars`*.
+ Возврат полученного массива *`arr`*.

# **Метод PrintArray(string[] arr)**

````
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
````
+ Метод **`PrintArray`** принимает один аргумент: массив строк *`arr`*.
+ Вывод пустой строки - это создает пробел перед печатью массива.
+ Вывод символа *`"["`*, который начинает вывод элементов массива.
+ Цикл *`for`* перебирает все элементы массива до предпоследнего.
+ В каждой итерации массива (кроме последнего элемента) данные элемента передаются в консоль.
+ Вывод последнего элемента массива, после которого расположена закрывающая скобка *`"]"`*.

# **Метод FilterArrayByLength(string[] arr, int maxLength)**

```
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
```
+ Метод **`FilterArrayByLength`** принимает два аргумента: массив строк *`arr`* и целое число *`maxLength`*.
+ Создание нового списка *`filteredList`*.
+ Цикл *`for`* перебирает каждый элемент массива *`arr`*.
+ В каждом цикле проверяется длина строки *`i`*-го элемента массива. Если длина строки меньше или равна *`maxLength`*, элемент добавляется в *`filteredList`*.
+ Возврат конвертированного в массив списка *`filteredList`*.

# **Блок-схема - Home Work Grand.drawio**
+ Link - https://drive.google.com/file/d/1GZWGfbAbmPHsucdoInRKTX4Yebd4m_oU/view?usp=sharing