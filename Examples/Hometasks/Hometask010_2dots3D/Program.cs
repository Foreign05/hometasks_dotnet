

// (xb - xa)2 + (yb - ya)2 + (zb - za)2

Console.WriteLine("Type 2 cordinates on a row like: x1, y1, z1, x2, y2, z2");
int[] arr = new int[6];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

int x = arr[3] - arr[0];
int y = arr[4] - arr[1];
int z = arr[5] - arr[2];

int res1 = x * x + y * y + z * z;

double d = Math.Sqrt(res1);

Console.Write(d);