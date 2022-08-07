// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

int[] Massif = new int[10];
int sum = 0;

void GoArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
}

void GetArray(int[] numbers)
{

    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}
void SumNum(int[] numbers)
{
    for (int z = 0; z < numbers.Length; z += 2)
    {
        sum = sum + numbers[z];
    }
}

Console.Write("массив: ");
GoArray( Massif, 0, 10);
GetArray(Massif);

SumNum(Massif);
Console.WriteLine($"сумма элементов на нечётных позициях = {sum}");