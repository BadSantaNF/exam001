// создаем метот для разделения строки
string [] GetArrayStringConsole (string inCosolSimcol)
{
    string[] arraySimvol = new string[inConsoleSimvol.Length];
    arraySimvol = inConsolSimvol.Split(",");
    return arraySimvol;
}

// создаем метот сортерующий символы

string[] ArrayTreeSimvol (string[] array)
{
    int count = 0
    for ( int i = 0; i < array.Length; i++)
    {
        string simvol = array[i];
        if (simvol.Length <=3)
        {
            count++;
        }
    }
    string[] ArrayTreeSimvol = new string[count]
    for (int i = 0 ,j = 0 ; i < array.Length;i++)
    {
        string simvol = array[i];
        if (simvol.Length <= 3)
        {
            ArrayTreeSimvol[j] = simvol;
            j++
        }
    }
    return ArrayTreeSimvol;
}
