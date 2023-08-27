
// Задача 36.
// Задайте одноммерный массив, заполненный случайными числами.
// Найдите сумму чисел стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19;
// [-4, -6, 89, 6] -> 0;

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
        array[i] = new Random().Next(-99, 100); 
    }
    return array;
}

int SumOfOdds(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            result += array[i];
        }
    }
    return result;
}

int input = ArrayLength();
int[] anyArray = GenerateArray(input);
int sum = SumOfOdds(anyArray);
Console.WriteLine($"[{String.Join(", ", anyArray)}] -> {sum}");