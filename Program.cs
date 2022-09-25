// Задача: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] > [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] > [“-2”]
// [“Russia”, “Denmark”, “Kazan”] > []

// string[] sArray = { "Hello", "2", "world", ":-)" };
string[] sArray = { "1234", "1567", "-2", "computer science" };
// string[] sArray = { "Russia", "Denmark", "Kazan" };

void PrintStringArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.Write("[]");
    }
    else
    {
        Console.Write("[");
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write($"\"{array[i]}\", ");
        }
        Console.Write($"\"{array[array.Length - 1]}\"]");
    }
}

string[] SmallStringsInArray(string[] array)
{
    int count = 0;
    string[] newArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count++] = array[i];
        }
    }
    Array.Resize(ref newArray, count);
    return newArray;
}

PrintStringArray(sArray);
string[] newSarray = SmallStringsInArray(sArray);
Console.Write(" -> ");
PrintStringArray(newSarray);