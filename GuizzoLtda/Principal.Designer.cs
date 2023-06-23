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
            btnUsuario.BackColor = Color.Black;
            btnUsuario.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuario.ForeColor = Color.White;
            btnUsuario.Location = new Point(196, 187);
            btnUsuario.Margin = new Padding(3, 4, 3, 4);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(298, 119);
            btnUsuario.TabIndex = 1;
            btnUsuario.Text = "Funcionário";
            btnUsuario.UseVisualStyleBackColor = false;
            btnUsuario.Click += btnUsuario_Click_1;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Black;
            btnAdmin.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(196, 425);
            btnAdmin.Margin = new Padding(3, 4, 3, 4);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(298, 116);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click_1;
            // 
            // label1
            // 
            label1.Font = new Font("Leelawadee UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(146, 53);
            label1.Name = "label1";
            label1.Size = new Size(398, 50);
            label1.TabIndex = 2;
            label1.Text = "Selecione seu Acesso";
            label1.Click += label1_Click;
            // 
            // PBEmpresa
            // 
            PBEmpresa.BackColor = SystemColors.MenuBar;
            PBEmpresa.BackgroundImageLayout = ImageLayout.Stretch;
            PBEmpresa.BorderStyle = BorderStyle.Fixed3D;
            PBEmpresa.Location = new Point(639, -2);
            PBEmpresa.Margin = new Padding(3, 4, 3, 4);
            PBEmpresa.Name = "PBEmpresa";
            PBEmpresa.Size = new Size(423, 675);
            PBEmpresa.SizeMode = PictureBoxSizeMode.StretchImage;
            PBEmpresa.TabIndex = 3;
            PBEmpresa.TabStop = false;
            PBEmpresa.Click += PBEmpresa_Click;
            // 
            // button1
            // 
            button1.Location = new Point(683, 316);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(173, 11, 0);
            ClientSize = new Size(1062, 673);
            Controls.Add(label1);
            Controls.Add(btnAdmin);
            Controls.Add(btnUsuario);
            Controls.Add(PBEmpresa);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selecione Usuario";
            Activated += Principal_Activated;
            Load += Principal_Load_1;
            ((System.ComponentModel.ISupportInitialize)PBEmpresa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUsuario;
        private Button btnAdmin;
        private Label label1;
        public PictureBox PBEmpresa;
        private Button button1;
    }
}