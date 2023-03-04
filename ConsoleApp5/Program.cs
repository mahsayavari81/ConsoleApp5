using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] a = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Enter value for [{i}, {j}]: ");
                int val = int.Parse(Console.ReadLine()!);
                a[i, j] = val;
            }
        }
        int determinant = (a[0, 0] * a[1, 1] * a[2, 2]
                    + a[0, 1] * a[1, 2] * a[2, 0]
                    + a[0, 2] * a[1, 0] * a[2, 1])
                    - (a[0, 2] * a[1, 1] * a[2, 0]
                    + a[0, 1] * a[1, 0] * a[2, 2]
                    + a[0, 0] * a[1, 2] * a[2, 1]);
        Console.WriteLine("Determinant: " + determinant);
    }
}
