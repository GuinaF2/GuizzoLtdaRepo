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
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PBEmpresa = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.Black;
            this.btnUsuario.Font = new System.Drawing.Font("Leelawadee UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Location = new System.Drawing.Point(172, 140);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(261, 89);
            this.btnUsuario.TabIndex = 1;
            this.btnUsuario.Text = "Funcionário";
            this.btnUsuario.UseVisualStyleBackColor = false;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Black;
            this.btnAdmin.Font = new System.Drawing.Font("Leelawadee UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(172, 319);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(261, 87);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione seu Acesso";
            // 
            // PBEmpresa
            // 
            this.PBEmpresa.BackColor = System.Drawing.SystemColors.MenuBar;
            this.PBEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBEmpresa.Location = new System.Drawing.Point(559, -2);
            this.PBEmpresa.Name = "PBEmpresa";
            this.PBEmpresa.Size = new System.Drawing.Size(371, 507);
            this.PBEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBEmpresa.TabIndex = 3;
            this.PBEmpresa.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(11)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(929, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.PBEmpresa);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecione Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.PBEmpresa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnUsuario;
        private Button btnAdmin;
        private Label label1;
        public PictureBox PBEmpresa;
        private Button button1;
    }
}