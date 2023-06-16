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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)PBEmpresa).BeginInit();
            SuspendLayout();
            // 
            // btnUsuario
            // 
            btnUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuario.Location = new Point(72, 115);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(261, 89);
            btnUsuario.TabIndex = 1;
            btnUsuario.Text = "Funcionário";
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click_1;
            // 
            // btnAdmin
            // 
            btnAdmin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdmin.Location = new Point(72, 268);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(261, 87);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(56, 30);
            label1.Name = "label1";
            label1.Size = new Size(284, 40);
            label1.TabIndex = 2;
            label1.Text = "Selecione seu Acesso";
            // 
            // PBEmpresa
            // 
            PBEmpresa.BackColor = SystemColors.MenuBar;
            PBEmpresa.BackgroundImageLayout = ImageLayout.Stretch;
            PBEmpresa.BorderStyle = BorderStyle.Fixed3D;
            PBEmpresa.Location = new Point(431, -1);
            PBEmpresa.Name = "PBEmpresa";
            PBEmpresa.Size = new Size(371, 452);
            PBEmpresa.SizeMode = PictureBoxSizeMode.StretchImage;
            PBEmpresa.TabIndex = 3;
            PBEmpresa.TabStop = false;
            PBEmpresa.Click += PBEmpresa_Click;
            // 
            // button1
            // 
            button1.Location = new Point(598, 237);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnAdmin);
            Controls.Add(btnUsuario);
            Controls.Add(PBEmpresa);
            Controls.Add(button1);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selecione Usuario";
            Activated += Principal_Activated;
            Load += Principal_Load_1;
            ((System.ComponentModel.ISupportInitialize)PBEmpresa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUsuario;
        private Button btnAdmin;
        private Label label1;
        public PictureBox PBEmpresa;
        private Button button1;
    }
}