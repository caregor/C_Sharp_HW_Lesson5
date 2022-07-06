/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

int[] GetRandomArray (int size)
{
    int[] mas = new int[size];
    for (int i = 0; i < size; i++)
    {
        mas[i] = new Random().Next(0,99);
    }
    return mas;
}

void PrintArray (int[] massive)
{
    System.Console.Write("[");
    for (int i = 1; i < massive.Length; i++)
    {
        System.Console.Write(massive[i - 1] + ", ");
    }
    System.Console.Write(massive[massive.Length - 1] + "]");
    //System.Console.WriteLine();
}

int Max (int[] mas)
{
    int max = mas[0];
    foreach (int element in mas)
    {
        if (element > max) max = element;
    }
    return max;
}

int Min (int[] mas)
{
     int min = mas[0];
    foreach (int element in mas)
    {
        if (element < min) min = element;
    }
    return min;
}

int[] massive = GetRandomArray(9);
PrintArray(massive);

int dif = Max(massive) - Min(massive);
System.Console.WriteLine(" -> " + dif);