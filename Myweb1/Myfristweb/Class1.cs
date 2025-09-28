using System;

namespace Myfristweb
{
    public class MatrixCalculator
    {
        private double[,] matrix;

        public MatrixCalculator(double[,] inputMatrix)
        {
            matrix = inputMatrix;
        }

        public double Determinant()
        {
            return Det(matrix);
        }

        private double Det(double[,] arr)
        {
            int n = arr.GetLength(0);
            if (n == 1) return arr[0, 0];
            if (n == 2) return arr[0, 0] * arr[1, 1] - arr[0, 1] * arr[1, 0];

            double det = 0;
            for (int col = 0; col < n; col++)
            {
                double[,] sub = CreateSubMatrix(arr, 0, col);
                int sign = (col % 2 == 0) ? 1 : -1;
                det += sign * arr[0, col] * Det(sub);
            }
            return det;
        }

        private double[,] CreateSubMatrix(double[,] arr, int removeRow, int removeCol)
        {
            int n = arr.GetLength(0);
            double[,] result = new double[n - 1, n - 1];
            int r = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == removeRow) continue;
                int c = 0;
                for (int j = 0; j < n; j++)
                {
                    if (j == removeCol) continue;
                    result[r, c] = arr[i, j];
                    c++;
                }
                r++;
            }
            return result;
        }

        public string Signature()
        {
            return "DLL MatrixCalculator by Hoàng Quyến 🚀";
        }
    }
}
