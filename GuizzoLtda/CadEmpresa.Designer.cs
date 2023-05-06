namespace GuizzoLtda
{
    partial class CadEmpresa
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
            this.btnEscolherFotoEmp = new System.Windows.Forms.Button();
            this.pbFotoEmp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEscolherFotoEmp
            // 
            this.btnEscolherFotoEmp.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEscolherFotoEmp.Location = new System.Drawing.Point(504, 351);
            this.btnEscolherFotoEmp.Name = "btnEscolherFotoEmp";
            this.btnEscolherFotoEmp.Size = new System.Drawing.Size(230, 55);
            this.btnEscolherFotoEmp.TabIndex = 0;
            this.btnEscolherFotoEmp.Text = "Cadastrar";
            this.btnEscolherFotoEmp.UseVisualStyleBackColor = true;
            this.btnEscolherFotoEmp.Click += new System.EventHandler(this.btnFotoEmp_Click);
            // 
            // pbFotoEmp
            // 
            this.pbFotoEmp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFotoEmp.Location = new System.Drawing.Point(504, 53);
            this.pbFotoEmp.Name = "pbFotoEmp";
            this.pbFotoEmp.Size = new System.Drawing.Size(230, 247);
            this.pbFotoEmp.TabIndex = 1;
            this.pbFotoEmp.TabStop = false;
            this.pbFotoEmp.Click += new System.EventHandler(this.pbFotoEmp_Click);
            // 
            // CadEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbFotoEmp);
            this.Controls.Add(this.btnEscolherFotoEmp);
            this.Name = "CadEmpresa";
            this.Text = "CadEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnEscolherFotoEmp;
        private PictureBox pbFotoEmp;
    }
}