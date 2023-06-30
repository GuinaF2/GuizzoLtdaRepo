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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
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
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuario.ForeColor = Color.Goldenrod;
            btnUsuario.Location = new Point(172, 140);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(261, 89);
            btnUsuario.TabIndex = 1;
            btnUsuario.Text = "Funcionário";
            btnUsuario.UseVisualStyleBackColor = false;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Black;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdmin.ForeColor = Color.Goldenrod;
            btnAdmin.Location = new Point(172, 319);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(261, 87);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Leelawadee UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(128, 40);
            label1.Name = "label1";
            label1.Size = new Size(348, 38);
            label1.TabIndex = 2;
            label1.Text = "Selecione seu Acesso";
            // 
            // PBEmpresa
            // 
            PBEmpresa.BackColor = SystemColors.MenuBar;
            PBEmpresa.BackgroundImageLayout = ImageLayout.Stretch;
            PBEmpresa.BorderStyle = BorderStyle.Fixed3D;
            PBEmpresa.Location = new Point(559, -2);
            PBEmpresa.Name = "PBEmpresa";
            PBEmpresa.Size = new Size(371, 507);
            PBEmpresa.SizeMode = PictureBoxSizeMode.StretchImage;
            PBEmpresa.TabIndex = 3;
            PBEmpresa.TabStop = false;
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
            BackColor = Color.FromArgb(173, 11, 0);
            ClientSize = new Size(929, 505);
            Controls.Add(label1);
            Controls.Add(btnAdmin);
            Controls.Add(btnUsuario);
            Controls.Add(PBEmpresa);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selecione Usuario";
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