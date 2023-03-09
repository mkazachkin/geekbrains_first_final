using System;

string tmp = "";
string separator = "\n";
Console.Clear();

Console.Write("Введите размерность массива: ");
int length = int.Parse(Console.ReadLine()!)!;

string[] in_array = StringArrayInput(length); // Метод объявлен далее  по коду

// Поиск элементов введенного массива длиной меньше 4
bool flag = false;
for (int i = 0; i < length; i++)
{
    if (in_array[i].Length < 4)
    {
        if (flag) tmp += separator;
        tmp += in_array[i];
        // Проверку на поднятый флаг не проверяем, проще записать в очередной раз true во флажок, чем каждый раз выполнять проверку
        flag = true;
    }
}

string[] out_array = tmp.Split(separator);
StringArrayPrint(out_array);  // Метод объявлен далее  по коду

// Предыдущие две команды можно заменить одной, если нет необходимости
// передать массив для обработки дальше
// StringArrayPrint (tmp.Split (separator));

//--- Пользовательские методы ---

// Метод для заполнения строкового массива длиной length
string[] StringArrayInput(int array_length)
{
    string[] result_array = new string[array_length];
    for (int i = 0; i < array_length; i++)
    {
        Console.Write($"Введите строку {i} массива: ");
        result_array[i] = Console.ReadLine()!;
    }
    return result_array;
}

// Метод оформленного вывода строкового массива
void StringArrayPrint(string[] array_for_print)
{
    Console.Write("[");
    for (int i = 0; i < array_for_print.Length; i++)
    {
        Console.Write($"{array_for_print[i]}");
        if (i != array_for_print.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}