
// Задание 35.
// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
// значания которых лежит на отрезке [10, 99].

// int ArrayLength()
// {
//     Console.WriteLine("Type a length of array: ");
//     int input = Convert.ToInt32(Console.ReadLine());
//     return input;
// }

// int[] Random123(int length)
// {
//     int[] array = new int[length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 10);
//     }
//     return array;
// }

// int TryToFind(int[] array)
// {
//     int res = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 10 && array[i] <= 99)
//         {
//             res++;
//         }
//     }
//     return res;
// }

// int input1 = ArrayLength();
// int[] array1 = Random123(input1);
// int res1 = TryToFind(array1);
// Console.WriteLine($"[{String.Join(", ", array1)}] -> {res1}");


// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задание 37.
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний элемент массива. Результат напишите в новом массиве.


int input1 = ArrayLength(); //defining array length
int[] array1 = Random123(input1); //creating an array according to inputted length
int half;
int some;
if (input1 % 2 == 0) //I сделал это условие, потому что не смог найти округление остатка 0,5 на высщую степень. 
{                     //we use this construction to replace our multiplication results to the new array   
    half = input1 / 2;
    some = array1.Length / 2;
}
else
{
    half = input1 / 2 + 1;
    some = array1.Length / 2 + 1;
}
int[] array2 = new int[half]; 
int times = array1.Length - 1; //backward counter
int[] array2real = ConvertToArray2(array1); //new array to replace results

Console.WriteLine($"[{String.Join(", ", array1)}] -> [{String.Join(", ", array2)}]"); //just print

int ArrayLength() //method that defines the length of array
{
    Console.WriteLine("Type a length of array: ");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

int[] Random123(int length) //filling array with random numbers
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

int[] ConvertToArray2(int[] array) //method that multiplies 2 numbers and replaces to another array
{
    for (int i = 0; i < some; i++)
    {
        array2[i] = array1[i] * array1[times];
        times--;
    }
    return array2;
}