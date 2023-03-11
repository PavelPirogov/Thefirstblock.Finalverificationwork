//  Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна 3 символа. 
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//  ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
//  ["1234", "1567", "-2", "computer science"] -> ["-2"]
//  ["Russia", "Denmark", "Kazan"] -> []

string[] GetArray(int m)
{
    string?[] arr = new String[m];
    for (int i = 0; i < m; i++)
    {
    again:
        System.Console.Write((i + 1) + " Введите чего-нибудь: ");
        arr[i] = Console.ReadLine();
        if (arr[i] == string.Empty)
        {
            System.Console.WriteLine("Вы ничего не ввели");
            goto again;
        }
    }
    return arr!;
}

void PrintArray(string[] arr)
{
    if (arr.Length == 0)
    {
        System.Console.WriteLine("[]");
    }
    else
    {
        System.Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            System.Console.Write('"' + arr[i] + '"');
            if (i < arr.Length - 1)
            {
                System.Console.Write(", ");
            }
        }
        System.Console.Write("]");
    }
}

string[] SelectValueLessFour(string[] arr)
{
    string result = string.Empty;
    string value = string.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        value = arr[i];
        if (value.Length <= 3)
        {
            result = result + " " + value;  // Записываем в строку значения массива в которых символов меньше четырёх
        }
    }
    if (result != string.Empty)
    {
        result = result.Remove(0, 1);           // Удаляем пробел в начале строки
        string[] select = result.Split(' ');    // Разбиваем строку через пробел и записываем в массив
        return select;
    }
    else
    {
        string[] select = new string[] { };     // Создаём пустой массив
        return select;
    }
}

int rand = new Random().Next(3, 6);
string[] array = GetArray(rand);
PrintArray(array);
System.Console.WriteLine();
PrintArray(SelectValueLessFour(array));




