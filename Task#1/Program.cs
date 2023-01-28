// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void PrintArray (double[,] Array)
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
void FillArray (double[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i,j] = new Random().Next(-20, 20) / 10.0;
        }
    }
}
double[,] Array = new double[3,4];
FillArray(Array);
PrintArray(Array);