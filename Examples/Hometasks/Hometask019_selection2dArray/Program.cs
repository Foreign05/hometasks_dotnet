// Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
//  и возвращает позицию этого элемента или же указание, что такого элемента нет.


const int cellWith = 4;
int[,] some = GetArray();
PrintArray(some);
int num = Prompt();
FindCertain(some, num);

int Prompt()
{
    Console.Write("Num to find: ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetArray()
{
    int m = new Random().Next(2, 10);
    int n = new Random().Next(2, 10);
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-99, 100);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],cellWith} ");
        }
        Console.WriteLine();
    }
}

void FindCertain(int[,] array, int num)
{
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num)
            {
                k++;
                Console.WriteLine($"{num} -> m = {i}, n = {j}");
                break;
            }
        }
    }
    if (k == 0)
    {
        Console.WriteLine("Nothing have founded");
    }
}
