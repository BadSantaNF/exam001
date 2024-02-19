// создаем метот для разделения строки
string[] GetArrayStringConsole (string inConsolSimvol)
{
    string[] arraySimvol = new string[inConsolSimvol.Length];
    arraySimvol = inConsolSimvol.Split(",");
    return arraySimvol;
}

// создаем метот сортерующий символы


string[] GetArrayThreeSimvol (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string simvol = array[i];
        if (simvol.Length <= 3)
        {
            count++;
        }
    }
    string[] arrayThreeSimvol = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        string simvol = array[i];
        if (simvol.Length <= 3)
        {
            arrayThreeSimvol[j] = simvol;
            j++;
        }
    }
    return arrayThreeSimvol;
}

// создаем метот void print

void Print (string[]  array )
{
    for (int i = 0 ; i < array.Length; i ++)
    {
        Console.Write($"{array[i]}, ");

    }
    Console.WriteLine();
}

// Создаем код для вызова методов и обработки текста через консоль

Console.Write("Введите набор символов через знак (,) - ");
string inStringSimvol = Console.ReadLine();
string[] arraySimvol = GetArrayStringConsole(inStringSimvol);
Console.WriteLine();
Console.Write("Введенные символы - ");
Print(arraySimvol);
Console.WriteLine();
Console.Write("Введенные символы длинной меньше либо равны 3 - ");
Print(GetArrayThreeSimvol(arraySimvol));
Console.WriteLine();

