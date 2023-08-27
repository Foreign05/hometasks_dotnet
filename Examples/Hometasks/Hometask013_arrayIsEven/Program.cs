
// Задача 34.
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2.

int ArrayLength()
{
    Console.WriteLine("Type the length of needed array: ");
    string input = Console.ReadLine();
    int number = Convert.ToInt32(input);
    return number;
}

int[] GenerateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000); 
    }
    return array;
}

int EvenCounter(int[] array)
{
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int input = ArrayLength();
int[] anyArray = GenerateArray(input);
int result = EvenCounter(anyArray);
Console.WriteLine($"[{String.Join(", ", anyArray)}] -> {result}");