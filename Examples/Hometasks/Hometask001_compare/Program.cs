



Console.WriteLine("Type first number:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type second number:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine(number1 + " is more than " + number2);
    Console.WriteLine(number2 + " is less than " + number1);
}
else 
{
    Console.WriteLine(number2 + " is more than " + number1);
    Console.WriteLine(number1 + " is less than " + number2);
}
