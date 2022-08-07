// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.


double[] GetArray = new double[10];
for (int i = 0; i < GetArray.Length; i++)
{
    GetArray[i] = new Random().Next(1, 10);

    Console.Write(GetArray[i] + " ");
}
double max = GetArray[0];
double min = GetArray[0];

for (int i = 1; i < GetArray.Length; i++)
{
    if (max < GetArray[i])
    {
        max = GetArray[i];
    }
    if (min > GetArray[i])
    {
        min = GetArray[i];
    }
}
double result = max - min;

Console.WriteLine($"\nразница между между max ({max}) и min ({min}) элементами: {result}");
