using System;
using Myfristweb; // <- namespace của DLL

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nhập kích thước ma trận vuông (n): ");
                int n = int.Parse(Console.ReadLine());

                double[,] a = new double[n, n];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"A[{i},{j}] = ");
                        a[i, j] = double.Parse(Console.ReadLine());
                    }
                }

                MatrixCalculator calc = new MatrixCalculator(a);
                double det = calc.Determinant();

                Console.WriteLine();
                Console.WriteLine("det(A) = " + det);
                Console.WriteLine(calc.Signature());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }

            Console.WriteLine("Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}
