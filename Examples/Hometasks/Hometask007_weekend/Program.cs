




int holiday1 = 6;
int holiday2 = 0;
Console.WriteLine("What is the day today?");
int input = Convert.ToInt32(Console.ReadLine());
int week = input % 7;

if (week == holiday1 || week == holiday2)
{
    Console.WriteLine("Today is holiday!");
}
else
{
    Console.WriteLine("Today is not holiday..");
}