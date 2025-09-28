using System;
using System.Web.UI;
using Myfristweb; // DLL

namespace MyWebAppllication
{
    public partial class Default : System.Web.UI.Page
    {
        protected void btnCalc_Click(object sender, EventArgs e)
        {
            int n;
            if (!int.TryParse(txtSize.Text, out n) || n <= 0)
            {
                lblResult.Text = "Kích thước ma trận không hợp lệ.";
                return;
            }

            string[] rows = txtMatrix.Text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            if (rows.Length != n)
            {
                lblResult.Text = "Số hàng của ma trận không đúng với kích thước n.";
                return;
            }

            double[,] matrix = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] cols = rows[i].Trim().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (cols.Length != n)
                {
                    lblResult.Text = $"Số cột ở hàng {i + 1} không đúng với kích thước n.";
                    return;
                }
                for (int j = 0; j < n; j++)
                {
                    if (!double.TryParse(cols[j], out matrix[i, j]))
                    {
                        lblResult.Text = $"Giá trị không hợp lệ tại hàng {i + 1}, cột {j + 1}.";
                        return;
                    }
                }
            }

            // Sử dụng class tính định thức từ DLL Myfristweb
            MatrixCalculator calc = new MatrixCalculator(matrix);
            double det = calc.Determinant();

            lblResult.Text = $"Định thức ma trận: {det}";
        }
    }
}