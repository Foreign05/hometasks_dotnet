
// Задача 38.
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементом массива.
// [3.0 7.0 22.5 2.0 78] -> 76


int ArrayLength()
{
    Console.WriteLine("Type the length of needed array: ");
    string input = Console.ReadLine();
    int number = Convert.ToInt32(input);
    return number;
}

double[] GenerateArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(-999, 1000) / 10.0); 
    }
    return array;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double FindDif(double elem1, double elem2)
{
    double result = 0; 
    if (elem1 < 0 || elem2 < 0)
    {
        result = elem1 + elem2;
    }
    else
    {
        result = elem1 - elem2;
    }
    result = Math.Round(result, 2);
    return result;
}

int input = ArrayLength();
double[] array = GenerateArray(input);
double min = FindMin(array);
double max = FindMax(array);
double result = FindDif(max, min);
Console.WriteLine($"[{String.Join(", ", array)}] -> {result}");
