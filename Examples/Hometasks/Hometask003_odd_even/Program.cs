


Console.WriteLine("Type any number : ");
int input = Convert.ToInt32(Console.ReadLine());

int devide = input % 2;

if (input == 0)
{
    Console.WriteLine("Zero is always zero!");
}
else
{
    if (devide == 0)
    {
        Console.WriteLine(input + " is even!");
    }
    else
    {
        Console.WriteLine(input + " is odd!");
    }
}