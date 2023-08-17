


while (true)
{
    Console.WriteLine("Type number from 100 to 1000: ");
    int input = Convert.ToInt32(Console.ReadLine());
    if (input > 100 && input < 1000)
    {
        int dev = input / 10;
        int dev1 = dev % 10;
        Console.WriteLine($"Second number is {dev1}!");
        break;
    }
}



