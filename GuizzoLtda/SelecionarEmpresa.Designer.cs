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
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)pbLogoEmp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgViewSelEmp).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogoEmp
            // 
            pbLogoEmp.Location = new Point(447, 26);
            pbLogoEmp.Name = "pbLogoEmp";
            pbLogoEmp.Size = new Size(353, 425);
            pbLogoEmp.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogoEmp.TabIndex = 1;
            pbLogoEmp.TabStop = false;
            // 
            // dgViewSelEmp
            // 
            dgViewSelEmp.AllowUserToAddRows = false;
            dgViewSelEmp.AllowUserToDeleteRows = false;
            dgViewSelEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgViewSelEmp.Location = new Point(0, 26);
            dgViewSelEmp.Name = "dgViewSelEmp";
            dgViewSelEmp.ReadOnly = true;
            dgViewSelEmp.RowTemplate.Height = 25;
            dgViewSelEmp.Size = new Size(450, 425);
            dgViewSelEmp.TabIndex = 2;
            dgViewSelEmp.CellContentClick += dgViewSelEmp_CellContentClick_1;
            dgViewSelEmp.CellDoubleClick += dgViewSelEmp_CellDoubleClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(447, 428);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(353, 23);
            textBox1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources._688879_arrows_512x512;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // SelecionarEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(dgViewSelEmp);
            Controls.Add(pbLogoEmp);
            Controls.Add(textBox1);
            Name = "SelecionarEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelecionarEmpresa";
            Load += SelecionarEmpresa_Load_1;
            ((System.ComponentModel.ISupportInitialize)pbLogoEmp).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgViewSelEmp).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogoEmp;
        private DataGridView dgViewSelEmp;
        private TextBox textBox1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
    }
}