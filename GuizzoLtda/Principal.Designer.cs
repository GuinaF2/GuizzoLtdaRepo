namespace GuizzoLtda
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PBEmpresa = new System.Windows.Forms.PictureBox();
            this.btnFotoEmp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUsuario
            // 
            this.btnUsuario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUsuario.Location = new System.Drawing.Point(425, 105);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(261, 89);
            this.btnUsuario.TabIndex = 0;
            this.btnUsuario.Text = "Funcionário";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click_1);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdmin.Location = new System.Drawing.Point(425, 258);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(261, 87);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(409, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione seu Usuário";
            // 
            // PBEmpresa
            // 
            this.PBEmpresa.BackColor = System.Drawing.SystemColors.MenuBar;
            this.PBEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBEmpresa.Location = new System.Drawing.Point(71, 91);
            this.PBEmpresa.Name = "PBEmpresa";
            this.PBEmpresa.Size = new System.Drawing.Size(217, 209);
            this.PBEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBEmpresa.TabIndex = 3;
            this.PBEmpresa.TabStop = false;
            this.PBEmpresa.Click += new System.EventHandler(this.PBEmpresa_Click);
            // 
            // btnFotoEmp
            // 
            this.btnFotoEmp.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFotoEmp.Location = new System.Drawing.Point(27, 348);
            this.btnFotoEmp.Name = "btnFotoEmp";
            this.btnFotoEmp.Size = new System.Drawing.Size(305, 52);
            this.btnFotoEmp.TabIndex = 4;
            this.btnFotoEmp.Text = "Selecionar";
            this.btnFotoEmp.UseVisualStyleBackColor = true;
            this.btnFotoEmp.Click += new System.EventHandler(this.btnFotoEmp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Selecione sua Empresa";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFotoEmp);
            this.Controls.Add(this.PBEmpresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnUsuario);
            this.Name = "Principal";
            this.Text = "Selecione Usuario";
            this.Load += new System.EventHandler(this.Principal_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.PBEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUsuario;
        private Button btnAdmin;
        private Label label1;
        private PictureBox PBEmpresa;
        private Button btnFotoEmp;
        private Label label2;
    }
}