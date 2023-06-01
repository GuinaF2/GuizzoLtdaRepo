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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewSelEmp)).BeginInit();
            this.toolStrip1.SuspendLayout();
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
            this.dgViewSelEmp.Location = new System.Drawing.Point(0, 26);
            this.dgViewSelEmp.Name = "dgViewSelEmp";
            this.dgViewSelEmp.ReadOnly = true;
            this.dgViewSelEmp.RowTemplate.Height = 25;
            this.dgViewSelEmp.Size = new System.Drawing.Size(450, 425);
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::GuizzoLtda.Properties.Resources._688879_arrows_512x512;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // SelecionarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgViewSelEmp);
            this.Controls.Add(this.pbLogoEmp);
            this.Controls.Add(this.textBox1);
            this.Name = "SelecionarEmpresa";
            this.Text = "SelecionarEmpresa";
            this.Load += new System.EventHandler(this.SelecionarEmpresa_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewSelEmp)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbLogoEmp;
        private DataGridView dgViewSelEmp;
        private TextBox textBox1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
    }
}