System.Console.WriteLine("Введите текст: ");
string text = Console.ReadLine();

if (text == string.Empty) System.Console.WriteLine("Не введено ни одного символа");
else
{
    string[] textArray = GetArrFromText(text);
    int size = GetSizeNewArr(textArray);
    string[] resultArray = GetResulArr(textArray, size);
    PrintArr(resultArray);
}
/// <summary>
/// GetArrFromText получает массив из строки
/// </summary>
/// <param name="str"></param>
/// <returns>
/// массив array
/// </returns>
string[] GetArrFromText(string str)
{
    char[] separators = new char[] { ' ', '.', ',', '!', '?'};
    string[] array = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return array;
}

/// <summary>
/// GetSizeNewArr получает размер нового массива
/// </summary>
/// <param name="arr"></param>
/// <returns>
/// число size
/// </returns>
int GetSizeNewArr(string[] arr)
{
    int size = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) size++;
    }
    return size;
}

/// <summary>
/// GetResulArr получает результирующий массив
/// </summary>
/// <param name="arr"></param>
/// <param name="size"></param>
/// <returns>
/// resultArr
/// </returns>
string[] GetResulArr(string[] arr, int size)
{
    int count = 0;
    string[] resultArr = new string[size];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            resultArr[count] = arr[i];
            count++;
        }
    }
    return resultArr;
}

/// <summary>
/// PrintArr выводит результирующий массив на экран
/// </summary>
/// <param name="arr"></param>
void PrintArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}
