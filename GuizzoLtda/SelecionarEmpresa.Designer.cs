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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgViewSelEmp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewSelEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(449, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.dgViewSelEmp.Size = new System.Drawing.Size(450, 389);
            this.dgViewSelEmp.TabIndex = 2;
            this.dgViewSelEmp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewSelEmp_CellContentClick);
            this.dgViewSelEmp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewSelEmp_CellContentClick);
            // 
            // SelecionarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgViewSelEmp);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SelecionarEmpresa";
            this.Text = "SelecionarEmpresa";
            this.Load += new System.EventHandler(this.SelecionarEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewSelEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dgViewSelEmp;
    }
}