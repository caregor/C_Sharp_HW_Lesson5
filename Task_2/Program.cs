/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] GetRandomArray (int size)
{
    int[] mas = new int[size];
    for (int i = 0; i < size; i++)
    {
        mas[i] = new Random().Next(0,9);
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

int TotalOddElements (int[] massive)
{
    int res = 0;
   for (int i = 1; i < massive.Length; i+=2)
   {
        res = res + massive[i];
   }

    return res;
}

int[] mas = GetRandomArray(4);
PrintArray(mas);

int total = TotalOddElements(mas);
System.Console.WriteLine(" -> " + total);