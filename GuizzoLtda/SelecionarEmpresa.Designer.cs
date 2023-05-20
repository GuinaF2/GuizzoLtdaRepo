namespace GuizzoLtda
{
    partial class SelecionarEmpresa
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
            pbLogoEmp = new PictureBox();
            dgViewSelEmp = new DataGridView();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbLogoEmp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgViewSelEmp).BeginInit();
            SuspendLayout();
            // 
            // pbLogoEmp
            // 
            pbLogoEmp.Location = new Point(447, 0);
            pbLogoEmp.Name = "pbLogoEmp";
            pbLogoEmp.Size = new Size(353, 451);
            pbLogoEmp.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogoEmp.TabIndex = 1;
            pbLogoEmp.TabStop = false;
            pbLogoEmp.Click += pictureBox1_Click;
            // 
            // dgViewSelEmp
            // 
            dgViewSelEmp.AllowUserToAddRows = false;
            dgViewSelEmp.AllowUserToDeleteRows = false;
            dgViewSelEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgViewSelEmp.Location = new Point(0, 0);
            dgViewSelEmp.Name = "dgViewSelEmp";
            dgViewSelEmp.ReadOnly = true;
            dgViewSelEmp.RowTemplate.Height = 25;
            dgViewSelEmp.Size = new Size(450, 451);
            dgViewSelEmp.TabIndex = 2;
            dgViewSelEmp.CellClick += dgViewSelEmp_CellContentClick;
            dgViewSelEmp.CellContentClick += dgViewSelEmp_CellContentClick;
            dgViewSelEmp.CellContentDoubleClick += dgViewSelEmp_CellContentDoubleClick;
            dgViewSelEmp.CellDoubleClick += dgViewSelEmp_CellDoubleClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(447, 428);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(353, 23);
            textBox1.TabIndex = 3;
            // 
            // SelecionarEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgViewSelEmp);
            Controls.Add(pbLogoEmp);
            Controls.Add(textBox1);
            Name = "SelecionarEmpresa";
            Text = "SelecionarEmpresa";
            Load += SelecionarEmpresa_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogoEmp).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgViewSelEmp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogoEmp;
        private DataGridView dgViewSelEmp;
        private TextBox textBox1;
    }
}