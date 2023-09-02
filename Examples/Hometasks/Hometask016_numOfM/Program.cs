
// Задание #41
// Пользователь вводит с клавиатуры М чисел.
// Посичтиайте сколько чисел больше 0 ввёл пользователь.
// [0, 7, 8, -2, -2] -> 2
// [-1, -7, 567, 89, 223] -> 3


int res = 0;
while (true)
{
    Console.WriteLine($"Entered positive numbers(M > 0): {res}");
    int input = Convert.ToInt32(Console.ReadLine());
    if (input > 0)
    {
        res++;
    }
    Console.Clear();
}

// If u wanna use it on Method =>

// int HigherZero()
// {
//     int res = 0;
//     while (true)
//     {
//         Console.WriteLine($"Entered positive numbers(M > 0): {res}");
//         int input = Convert.ToInt32(Console.ReadLine());
//         if (input > 0)
//         {
//             res++;
//         }
//         Console.Clear();
//     }
//     return res;
// }

// HigherZero();