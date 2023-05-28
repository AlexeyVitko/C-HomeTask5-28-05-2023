// Задача 34: 
// 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
// 2. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2



int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
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

int numbers = EvenNumber(array);

int count = 0;

int[] EvenNumber (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
{
        if (arr[i] % 2 == 0)
            count++;
}
return count;
}
  Console.WriteLine($"всего {arr.Length} чисел, {count} из них чётные");

    int[] array = CreateArrayRndInt(12, 1, 9);
    Console.Write("[");
    PrintArray(array, ",");
    Console.WriteLine("]");

