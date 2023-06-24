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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelecionarEmpresa));
            pbLogoEmp = new PictureBox();
            dgViewSelEmp = new DataGridView();
            textBox1 = new TextBox();
            linkCadEmp = new LinkLabel();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogoEmp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgViewSelEmp).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogoEmp
            // 
            pbLogoEmp.BackColor = SystemColors.ButtonHighlight;
            pbLogoEmp.BackgroundImageLayout = ImageLayout.Stretch;
            pbLogoEmp.InitialImage = null;
            pbLogoEmp.Location = new Point(447, 26);
            pbLogoEmp.Name = "pbLogoEmp";
            pbLogoEmp.Size = new Size(482, 480);
            pbLogoEmp.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogoEmp.TabIndex = 1;
            pbLogoEmp.TabStop = false;
            // 
            // dgViewSelEmp
            // 
            dgViewSelEmp.AllowUserToAddRows = false;
            dgViewSelEmp.AllowUserToDeleteRows = false;
            dgViewSelEmp.BackgroundColor = SystemColors.ActiveCaptionText;
            dgViewSelEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgViewSelEmp.Location = new Point(0, 28);
            dgViewSelEmp.Name = "dgViewSelEmp";
            dgViewSelEmp.ReadOnly = true;
            dgViewSelEmp.RowHeadersWidth = 51;
            dgViewSelEmp.RowTemplate.Height = 25;
            dgViewSelEmp.Size = new Size(450, 478);
            dgViewSelEmp.TabIndex = 2;
            dgViewSelEmp.CellContentClick += dgViewSelEmp_CellContentClick;
            dgViewSelEmp.CellContentDoubleClick += dgViewSelEmp_CellContentDoubleClick;
            dgViewSelEmp.CellDoubleClick += dgViewSelEmp_CellDoubleClick_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(447, 428);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(353, 23);
            textBox1.TabIndex = 3;
            // 
            // linkCadEmp
            // 
            linkCadEmp.AutoSize = true;
            linkCadEmp.BackColor = Color.Black;
            linkCadEmp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkCadEmp.ForeColor = Color.Goldenrod;
            linkCadEmp.LinkColor = Color.Goldenrod;
            linkCadEmp.Location = new Point(685, 2);
            linkCadEmp.Name = "linkCadEmp";
            linkCadEmp.Size = new Size(244, 21);
            linkCadEmp.TabIndex = 8;
            linkCadEmp.TabStop = true;
            linkCadEmp.Text = "Não Possui Cadastro? Clique Aqui";
            linkCadEmp.LinkClicked += linkCadEmp_LinkClicked_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -12);
            panel1.Name = "panel1";
            panel1.Size = new Size(929, 518);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(72, 5);
            label1.Name = "label1";
            label1.Size = new Size(258, 32);
            label1.TabIndex = 0;
            label1.Text = "Selecione sua empresa";
            // 
            // SelecionarEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 505);
            ControlBox = false;
            Controls.Add(linkCadEmp);
            Controls.Add(dgViewSelEmp);
            Controls.Add(pbLogoEmp);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SelecionarEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelecionarEmpresa";
            Load += SelecionarEmpresa_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogoEmp).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgViewSelEmp).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox pbLogoEmp;
        private DataGridView dgViewSelEmp;
        private TextBox textBox1;
        private ToolStrip toolStrip1;
        private LinkLabel linkCadEmp;
        private Panel panel1;
        private Label label1;
    }
}