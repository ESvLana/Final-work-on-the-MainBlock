string[] stringarr = new string[] { "Hello", "2", "world", "Kazan", ":-)", " " };

int CountSymbolsInString(string[] Array)   //для подсчёта количества символов в строке
{
    int counter = 0;
    foreach (string item in Array)
    {
        if (item.Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}

string[] CreateNewArray(string[] Array)    //для создания нового массива, состоящего из строк, длина которых меньше либо равна 3 символам
{
    int ArrayLength = CountSymbolsInString(Array);
    string[] NewArray = new string[ArrayLength];
    int i = 0;
    foreach (string item in Array)
    {
        if (item.Length <= 3)
        {
            NewArray[i] = item;
            i++;
        }
    }
    return NewArray;
}

void PrintArray(string[] Аrray)  
{
    string stringArray = "[";
    for (int i = 0; i < Аrray.Length; i++)
    {
        if (i == Аrray.Length - 1)
        {
            stringArray += $"\"{Аrray[i]}\"";
            break;
        }
        stringArray += ($"\"{Аrray[i]}\", ");
    }
    stringArray += "]";
    Console.WriteLine(stringArray);
}

string[] NewArray = CreateNewArray(stringarr);
PrintArray(NewArray);