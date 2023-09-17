
// Задайте двумерный массив из целых чисел
// Найдите среднее арифметическое элементов в каждом столбце


const int cellWith = 3;
int[,] some = GetArray();
PrintArray(some);
int[] sum = SumOfArray(some);
Avarage(some, sum);

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetArray()
{
    int m = Prompt("Type m -> ");
    int n = Prompt("Type n -> ");
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
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

int[] SumOfArray(int[,] array)
{
    int[] sum = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int k = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            k += array[j, i];
        }
        sum[i] = k;
    }
    return sum;
}

void Avarage(int[,] array2d, int[] array)
{
    double row = array2d.GetLength(0);
    double[] av_array = new double[array2d.GetLength(1)];
    for (int i = 0; i < av_array.Length; i++)
    {
        av_array[i] = array[i] / row;
        av_array[i] = Math.Round(av_array[i], 2);
    }
    Console.WriteLine();
    Console.WriteLine($"{String.Join(", ", av_array)}");
}