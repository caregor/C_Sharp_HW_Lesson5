/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

void PrintArray (int[] massive)
{
    for (int i = 1; i < massive.Length; i++)
    {
        System.Console.Write(massive[i - 1] + ", ");
    }
    System.Console.Write(massive[massive.Length - 1]);
    //System.Console.WriteLine();
}

int[] GetRandomArray (int size)
{
    int[] mas = new int[size];
    for (int i = 0; i < size; i++)
    {
        mas[i] = new Random().Next(100,999);
    }
    return mas;
}

int GetAllEven(int [] massive)
{   
    int res = 0;
    foreach (int element in massive)
    {
        if (element % 2 == 0) res++;
    }
    return res;
}

int[] massive = GetRandomArray(10);

System.Console.Write("[");
PrintArray(massive);
System.Console.Write("] -> ");

int even = GetAllEven(massive);

System.Console.WriteLine(even);