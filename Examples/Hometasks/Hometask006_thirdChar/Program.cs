

Console.WriteLine("Type any number: ");
int input = Convert.ToInt32(Console.ReadLine());

int a = 999;
int b = 99;

if (input < b)
{
    Console.WriteLine("Third position is empty");
}
else if (input <= a)
{
    input = input % 10;
    Console.WriteLine("Third char is -> " + input);
}
else 
{
    while (input > a)
    {
        input = input / 10;
    }
    
    input = input % 10;
    Console.WriteLine("Third char is -> " + input);
}