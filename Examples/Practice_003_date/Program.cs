


Console.WriteLine("Type any number: ");
int input = Convert.ToInt32(Console.ReadLine());
Console.Write("It is, ");
int test = input % 7; // если число делится на неделю ровно то это точно Воскресенье

if (test == 0)
{
    Console.WriteLine("Sunday"); // подтверждаем что это воскр.
}

if (input > 7)
{
    input = input % 7; // любое число можно разделить на 7, число после запятой будет равен дню недели 
}


if (input == 1)
{
    Console.WriteLine("Monday");
}
if (input == 2)
{
    Console.WriteLine("Tuesday");
}
if (input == 3)
{
    Console.WriteLine("Wednesday");
}
if (input == 4)
{
    Console.WriteLine("Thursday");
}
if (input == 5)
{
    Console.WriteLine("Friday");
}
if (input == 6)
{
    Console.WriteLine("Saturday");
}
if (input == 7)
{
    Console.WriteLine("Sunday");
}









// Its easier way to do stuff that we have done heigher)))
// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// switch (number)
// {
// case 1:
// Console.WriteLine("Monday");
// break;
// case 2:
// Console.WriteLine("Tuesday");
// break;
// case 3:
// Console.WriteLine("Wednesday");
// break;
// case 4:
// Console.WriteLine("Thursday");
// break;
// case 5:
// Console.WriteLine("Friday");
// break;
// case 6:
// Console.WriteLine("Saturday");
// break;
// case 7:
// Console.WriteLine("Sunday");
// break;
// default:
// Console.WriteLine("Такого дня не существует");
// break;
// }