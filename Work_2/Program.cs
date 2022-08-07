// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

int[] Massif = new int[10];
int sum = 0;

void RandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(0, 10);
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

RandomNumbers(Massif);
Console.WriteLine("массив: ");
GetArray(Massif);

SumNum(Massif);
Console.WriteLine($"сумма элементов на нечётных позициях = {sum}");