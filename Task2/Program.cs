// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] GetArrayRandom(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}
void PrintArray(int[] array)
{
    {
        Console.WriteLine(string.Join(", ", array));
    }
}
int SumOddPositionElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i%2 != 0) sum = sum + array[i];
    }
    return sum;
}

int[] array = GetArrayRandom(8);
PrintArray(array);
Console.WriteLine($"Сумма элементов на нечетных позициях: {SumOddPositionElements(array)}");