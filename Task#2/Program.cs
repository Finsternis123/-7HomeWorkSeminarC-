//Напишите программу, которая на вход принимает число, и проверяет есть ли такое число в двумерном массиве, а также возвращает сообщение о том, что оно найдено или же указание, что такого элемента нет.
Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine()!);

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
            Array[i,j] = new Random().Next(0, 100);
        }
    }
}
int[,] Array = new int[3,4];
FillArray(Array);
PrintArray(Array);

bool SearchEl(int[,] Array, int num)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Array[i,j] == num)
            return true;
        }
    } 
    return false; 
}

if (SearchEl(Array,num))
{
    Console.WriteLine("Такое число есть");
}
else
{
    Console.WriteLine("Такого числа нет");
}

// foreach (int el in Array)
// {
//     if (el == num)
//     {
//         Console.WriteLine("Такое число есть"); 
//         break;
//     }
// }