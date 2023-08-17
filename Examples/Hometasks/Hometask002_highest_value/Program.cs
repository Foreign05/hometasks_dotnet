


Console.WriteLine("Type first number:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type second number:");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type third number:");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2 && number1 > number3)
{
    Console.WriteLine("The highest one is : " + number1);
}
else if (number2 > number3 && number2 > number1)
{
    Console.WriteLine("The highest one is : " + number2);
}
else
{
    Console.WriteLine("The highest one is : " + number3);
}