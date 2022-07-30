// Разница между максимальным и минимальным элементом массива вещественных чисел
double[] array = {5.1, 8.2, 9.9, 25.8, 3.14, 14.2};

double FindMax(double[] array)
{
double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
    }
return max;
}

double FindMin(double[] array)
{
double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
    }
return min;
}
System.Console.WriteLine($"Max element: {FindMax(array)}");
System.Console.WriteLine($"Min element: {FindMin(array)}");
System.Console.WriteLine($"Difference Max-Min: {FindMax(array) - FindMin(array)}");