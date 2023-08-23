
// Straight Method =>
Console.WriteLine("Type any number: ");

int input = Convert.ToInt32(Console.ReadLine());

int a = input * input;
int res = 0;

for (int i = 0; i <= input; i++)
{
    while (i > 0)
    {
        res = i * i;
        if (res == a)
        {
            Console.Write(res + ".");
        }
        else
        {
            Console.Write(res + ", ");
        }
        
        break;
    }
}





// Reversive Method =>
// int res1 = 0;

// Console.WriteLine("Type any number: ");
// int input = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i <= input; i++)
// {
//     while (input != 0)
//     {
//         res1 = input * input;
//         Console.Write(res1 + ", ");
//         input--;
//     }
// }
