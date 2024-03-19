//Задайте произвольный массив. Выведете его элементы, начиная с конца.
//Использовать рекурсию, не использовать цикл.
int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int size)
{
    Random random = new Random();
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = random.Next(0,100);
    }
    return array;
}

void PrintArray(int[] arr, int index)
{
    if(index < arr.Length)
    {
        PrintArray(arr, index + 1);
        System.Console.Write(arr[index] + " ");
    }
}

int Size = ReadInt("Введите размер массива: ");
int[] array = CreateArray(Size);
Console.WriteLine("Сгенерированный массив: ");
    foreach (int num in array)
    {
        System.Console.Write(num + " ");
    }
Console.WriteLine();
PrintArray(array,0);