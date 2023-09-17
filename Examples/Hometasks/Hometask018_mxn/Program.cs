// Задайте двумерный массив размером m x n, заполненный случайными вещественными числами. 


const int cellWith = 6;
double[,] some = GetArray();
PrintArray(some);


int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GetArray()
{
    int m = Prompt("Type m -> ");
    int n = Prompt("Type n -> ");
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double num1 = new Random().Next(1, 10);
            double num2 = new Random().Next(0, 10);
            double res = 0;
            if (num2 == 0) res = num2 / num1;
            else res = num1 / num2;
            res = Math.Round(res, 2);
            array[i, j] = res;
        }
    }
    return array;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j], cellWith} ");
        }
        Console.WriteLine();
    }
}
