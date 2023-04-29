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
            btnUsuario = new Button();
            btnAdmin = new Button();
            label1 = new Label();
            PBEmpresa = new PictureBox();
            btnFotoEmp = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)PBEmpresa).BeginInit();
            SuspendLayout();
            // 
            // btnUsuario
            // 
            btnUsuario.Location = new Point(482, 139);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(184, 35);
            btnUsuario.TabIndex = 0;
            btnUsuario.Text = "Funcionário";
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(482, 281);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(184, 37);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(469, 19);
            label1.Name = "label1";
            label1.Size = new Size(197, 25);
            label1.TabIndex = 2;
            label1.Text = "Selecione seu Usuário";
            // 
            // PBEmpresa
            // 
            PBEmpresa.Location = new Point(47, 90);
            PBEmpresa.Name = "PBEmpresa";
            PBEmpresa.Size = new Size(217, 209);
            PBEmpresa.TabIndex = 3;
            PBEmpresa.TabStop = false;
            // 
            // btnFotoEmp
            // 
            btnFotoEmp.Location = new Point(58, 347);
            btnFotoEmp.Name = "btnFotoEmp";
            btnFotoEmp.Size = new Size(197, 37);
            btnFotoEmp.TabIndex = 4;
            btnFotoEmp.Text = "Selecionar";
            btnFotoEmp.UseVisualStyleBackColor = true;
            btnFotoEmp.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(67, 35);
            label2.Name = "label2";
            label2.Size = new Size(168, 21);
            label2.TabIndex = 5;
            label2.Text = "Selecione sua Empresa";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnFotoEmp);
            Controls.Add(PBEmpresa);
            Controls.Add(label1);
            Controls.Add(btnAdmin);
            Controls.Add(btnUsuario);
            Name = "Principal";
            Text = "Selecione Usuario";
            Load += Principal_Load;
            ((System.ComponentModel.ISupportInitialize)PBEmpresa).EndInit();
            ResumeLayout(false);
            PerformLayout();
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