//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] Array = new int[4,5];
void PrintArray (int[,] Array)
{
for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        Console.Write($"{Array[i , j]} ");
    }
    Console.WriteLine();
}
}
void FillArray (int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i,j] = new Random().Next(10, 20);
        }
    }
}

FillArray(Array);

for (int j = 0; j < Array.GetLength(1); j++)
{
    double mid = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        mid = (mid + Array[i, j]);
    }
    mid = mid / Array.GetLength(0);
    Console.Write(mid + "; ");
}
Console.WriteLine();
PrintArray(Array);