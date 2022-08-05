// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

int[] Massif = new int[10];

void GetArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void GoArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int EvenValue(int[] array)
{
    int value = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            value++;
        }
    }
    return value;
}

GetArray(Massif, 100, 1000);
GoArray(Massif);
Console.WriteLine();

int value = EvenValue(Massif);
Console.WriteLine($"Чётных чисел в массиве: {value}");

