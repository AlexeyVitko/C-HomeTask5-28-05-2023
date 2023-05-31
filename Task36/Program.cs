// Задача 36: 
// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());


int[] array = CreateArrayRndInt(size, -10, 100);
Console.WriteLine($"всего {size} чисел, сумма элементов на нечётных позициях = {SumOddNumber(array)}");
Console.Write("[");
PrintArray(array, ",");
Console.WriteLine($"] -> {SumOddNumber(array)}");

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}


void PrintArray(int[] arr, string sep) //sep - параметр для разделения (запятая и прочие)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

int SumOddNumber(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
     sum = sum + arr[i];
    }
    return sum;
}

