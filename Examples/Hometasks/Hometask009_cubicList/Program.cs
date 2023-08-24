
// Напишите программу которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.




Console.WriteLine("Type any number: ");

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
        int another = Convert.ToInt32(input);
        int a = another * another;
        int res = 0;

        for (int i = 0; i <= another; i++)
        {
            while (i > 0)
            {
                res = i * i * i;
                if (res == a * another)
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
        break;
    }
    
}