Console.Clear();

string[] arrOne = FillArray();
int sizeEl = SetMaxLenghtEl();
int newSize = FindSizeElem(arrOne, sizeEl);
if (newSize == 0)
{
    Console.WriteLine("Нет подходящих элементов");
}
else
{
    Console.WriteLine($"[{String.Join(",", arrOne)}] --> [{String.Join(",", CreatNewArray(arrOne, newSize, sizeEl))}]");
}

string InputWrite(string message)
{
    Console.Write(message);
    return Console.ReadLine()!;
}

string[] FillArray()
{
    int arrLength = int.Parse(InputWrite("Введите размер массива: "));
    string[] array = new string[arrLength];
    for (int i = 0; i < arrLength; i++)
    {
        array[i] = InputWrite($"Введите {i + 1} элемент массива: ");
    }
    return array;
}

int SetMaxLenghtEl() //Возможность самому указывать размер элемента
{
    Console.WriteLine("Укажите размер элемента для нового массива (оставьте поле пустым, для использования числа по умолчанию `3`):");
    string n = Console.ReadLine();
    int num;
    if (n.Length == 0) num = 3;
    else num = int.Parse(n);
    return num;
}

int FindSizeElem(string[] arr, int k)
{
    int countSize = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= k) countSize++;
    }
    return countSize;
}

string[] CreatNewArray(string[] arr, int size, int k)
{
    string[] arrayTwo = new string[size];
    for (int i = 0, j = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= k)
        {
            arrayTwo[j] = arr[i];
            j++;
        }
    }
    return arrayTwo;
}
