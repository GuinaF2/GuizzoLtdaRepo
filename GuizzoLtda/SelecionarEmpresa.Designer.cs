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
            this.pbLogoEmp = new System.Windows.Forms.PictureBox();
            this.dgViewSelEmp = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewSelEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogoEmp
            // 
            this.pbLogoEmp.Location = new System.Drawing.Point(447, 0);
            this.pbLogoEmp.Name = "pbLogoEmp";
            this.pbLogoEmp.Size = new System.Drawing.Size(353, 451);
            this.pbLogoEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoEmp.TabIndex = 1;
            this.pbLogoEmp.TabStop = false;
            // 
            // dgViewSelEmp
            // 
            this.dgViewSelEmp.AllowUserToAddRows = false;
            this.dgViewSelEmp.AllowUserToDeleteRows = false;
            this.dgViewSelEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewSelEmp.Location = new System.Drawing.Point(0, 0);
            this.dgViewSelEmp.Name = "dgViewSelEmp";
            this.dgViewSelEmp.ReadOnly = true;
            this.dgViewSelEmp.RowTemplate.Height = 25;
            this.dgViewSelEmp.Size = new System.Drawing.Size(450, 451);
            this.dgViewSelEmp.TabIndex = 2;
            this.dgViewSelEmp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewSelEmp_CellContentClick_1);
            this.dgViewSelEmp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewSelEmp_CellDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(447, 428);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 23);
            this.textBox1.TabIndex = 3;
            // 
            // SelecionarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgViewSelEmp);
            this.Controls.Add(this.pbLogoEmp);
            this.Controls.Add(this.textBox1);
            this.Name = "SelecionarEmpresa";
            this.Text = "SelecionarEmpresa";
            this.Load += new System.EventHandler(this.SelecionarEmpresa_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewSelEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbLogoEmp;
        private DataGridView dgViewSelEmp;
        private TextBox textBox1;
    }
}