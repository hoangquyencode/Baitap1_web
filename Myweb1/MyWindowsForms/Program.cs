using System;
using System.Windows.Forms;
using Myfristweb; // namespace của DLL bạn đã tạo (chứa Class1.cs)

namespace MyWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Nút tạo ma trận
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSize.Text, out int n) && n > 0)
            {
                dgvMatrix.ColumnCount = n;
                dgvMatrix.RowCount = n;

                // Đặt tiêu đề cột
                for (int i = 0; i < n; i++)
                {
                    dgvMatrix.Columns[i].HeaderText = "C" + (i + 1);
                    dgvMatrix.Columns[i].Width = 50;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương cho n");
            }
        }

        // Nút giải bài toán
        private void btnSolve_Click(object sender, EventArgs e)
        {
            int n = dgvMatrix.RowCount;
            int[,] matrix = new int[n, n];

            try
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = int.Parse(dgvMatrix.Rows[i].Cells[j].Value.ToString());
                    }
                }

                // Chuyển ma trận int[,] sang double[,]
                double[,] mat = new double[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        mat[i, j] = matrix[i, j];
                    }
                }

                // Gọi DLL
                MatrixCalculator calc = new MatrixCalculator(mat);
                double det = calc.Determinant();

                // Hiển thị kết quả
                lblResult.Text = $"det(A) = {det}\n{calc.Signature()}";

                lblResult.Text = "Kết quả: " + result;
            }
            catch
            {
                MessageBox.Show("Có lỗi khi đọc dữ liệu ma trận. Vui lòng nhập đầy đủ số!");
            }
        }
    }
}
