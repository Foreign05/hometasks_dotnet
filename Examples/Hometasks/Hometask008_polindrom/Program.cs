
// Напишите программу которая принимает на вход пятизначное число, и проверяет, является ли число палиндромом
// 14212 -> нет
// 23432 -> да
// 12821 -> да

while (true)
{
    string input = Console.ReadLine();
    int number;

    if (!int.TryParse(input, out number))
    {
        Console.WriteLine("Try to type just numbers");
    } 
    else
    {
        if (input.Length != 5) 
        {
            Console.WriteLine("Input is to short");
        }
        else 
        {
            if (input[0] == input[4] && input[1] == input[3])
            {
                Console.WriteLine("yes");
                break;
            }
            else
            {
                Console.WriteLine("no");
                break;
            }
        }
    }   
}


















































// string[] arr = new string[5];

// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = Console.ReadLine();

//     int len = arr[i].Length;

//     foreach (var value in arr)
//     {
//         int number;
//         bool success = int.TryParse(value, out number);

//         if (success)
//         {
            
//             while (len == 5)
//             {
//                 if (true)
//                 {
//                     Array.Reverse(arr);
//                     foreach (var item in arr)
//                     {
//                         Console.WriteLine(item);
//                     }
//                 }
//                 else
//                 {
//                     Console.WriteLine("Your numer have to consist 5 chars");
//                 }
//                 break;
//             }

//         }
//         else
//         {
//             Console.Clear();
//             Console.WriteLine("Type just numbers");
//         }
//     }
    
// }
