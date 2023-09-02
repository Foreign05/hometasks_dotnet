
// Напишите программу, которая найдет точку пересечения двух прямых, 
// заднных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2, k2 задаются пользователем


string a = "b1";
string b = "k1";
string c = "b2";
string d = "k2";

int num1 = GetVariables(a);
int num2 = GetVariables(b);
int num3 = GetVariables(c);
int num4 = GetVariables(d);
int x = 1;

Intersection(num1, num2, num3, num4);

int GetVariables(string abcd)
{
    Console.Write($"Type {abcd} => ");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

void Intersection(int one, int two, int three, int four)
{
    for (int j = 1; j < 5 ; j--)
    {
        x = j;
        int y1 = two * x + one;
        int y2 = four * x + three;
        if (y1 == y2)
        {
            Console.WriteLine($"Intersection point on X = {j}");
            break;
        }
    }
}