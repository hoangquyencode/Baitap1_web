using System;
using System.Windows.Forms;
using Myfristweb; // DLL

namespace MyWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSize.Text);
            dgvMatrix.ColumnCount = n;
            dgvMatrix.RowCount = n;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int n = dgvMatrix.RowCount;
            double[,] a = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = double.Parse(dgvMatrix[j, i].Value.ToString());
                }
            }

            MatrixCalculator calc = new MatrixCalculator(a);
            double det = calc.Determinant();

            lblResult.Text = "det(A) = " + det + Environment.NewLine + calc.Signature();
        }
    }
}
