// Массив, заполненный случайными положительными трёхзначными числами и количество чётных чисел в массиве.
int[] GetArrayRandom(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int EvenNumbersCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0) count++;
    }
    return count;
}
int[] array = GetArrayRandom(10);
PrintArray(array);
Console.WriteLine(string.Empty);
Console.WriteLine($"Количество четных чисел в массиве: {EvenNumbersCount(array)}");