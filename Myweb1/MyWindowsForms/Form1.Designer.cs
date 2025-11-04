namespace MyWindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSize = new System.Windows.Forms.TextBox();
            this.dgvMatrix = new System.Windows.Forms.DataGridView();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(30, 20);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 22);
            this.txtSize.TabIndex = 0;
            // 
            // dgvMatrix
            // 
            this.dgvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrix.Location = new System.Drawing.Point(30, 60);
            this.dgvMatrix.Name = "dgvMatrix";
            this.dgvMatrix.RowHeadersWidth = 51;
            this.dgvMatrix.RowTemplate.Height = 24;
            this.dgvMatrix.Size = new System.Drawing.Size(400, 200);
            this.dgvMatrix.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(30, 280);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(64, 16);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Kết quả: ";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(150, 20);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(120, 25);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Tạo ma trận";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(280, 20);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(120, 25);
            this.btnSolve.TabIndex = 4;
            this.btnSolve.Text = "Giải";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.dgvMatrix);
            this.Controls.Add(this.txtSize);
            this.Name = "Form1";
            this.Text = "Matrix Solver";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.DataGridView dgvMatrix;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSolve;
    }
}
