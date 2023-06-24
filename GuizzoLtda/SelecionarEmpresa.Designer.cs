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
            this.pbLogoEmp = new System.Windows.Forms.PictureBox();
            this.dgViewSelEmp = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.linkCadEmp = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewSelEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogoEmp
            // 
            this.pbLogoEmp.InitialImage = null;
            this.pbLogoEmp.Location = new System.Drawing.Point(447, 26);
            this.pbLogoEmp.Name = "pbLogoEmp";
            this.pbLogoEmp.Size = new System.Drawing.Size(353, 425);
            this.pbLogoEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoEmp.TabIndex = 1;
            this.pbLogoEmp.TabStop = false;
            // 
            // dgViewSelEmp
            // 
            this.dgViewSelEmp.AllowUserToAddRows = false;
            this.dgViewSelEmp.AllowUserToDeleteRows = false;
            this.dgViewSelEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewSelEmp.Location = new System.Drawing.Point(0, 26);
            this.dgViewSelEmp.Name = "dgViewSelEmp";
            this.dgViewSelEmp.ReadOnly = true;
            this.dgViewSelEmp.RowHeadersWidth = 51;
            this.dgViewSelEmp.RowTemplate.Height = 25;
            this.dgViewSelEmp.Size = new System.Drawing.Size(450, 425);
            this.dgViewSelEmp.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(447, 428);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 23);
            this.textBox1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(929, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // linkCadEmp
            // 
            this.linkCadEmp.AutoSize = true;
            this.linkCadEmp.Location = new System.Drawing.Point(614, 10);
            this.linkCadEmp.Name = "linkCadEmp";
            this.linkCadEmp.Size = new System.Drawing.Size(186, 15);
            this.linkCadEmp.TabIndex = 8;
            this.linkCadEmp.TabStop = true;
            this.linkCadEmp.Text = "Não Possui Cadastro? Clique Aqui";
            // 
            // SelecionarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 505);
            this.ControlBox = false;
            this.Controls.Add(this.linkCadEmp);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgViewSelEmp);
            this.Controls.Add(this.pbLogoEmp);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelecionarEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelecionarEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewSelEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public PictureBox pbLogoEmp;
        private DataGridView dgViewSelEmp;
        private TextBox textBox1;
        private ToolStrip toolStrip1;
        private LinkLabel linkCadEmp;
    }
}