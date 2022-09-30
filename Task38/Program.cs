// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

double DifferenceMaxMinArrayElements(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max )
        {
            max = arr[i];
        }
        if (arr[i] < min )
        {
            min = arr[i];
        }
    }
    return max-min;
}

double[] array = new double[4];
FillArray(array);
PrintArray(array);
Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + DifferenceMaxMinArrayElements(array));