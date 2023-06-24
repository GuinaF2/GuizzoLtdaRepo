namespace GuizzoLtda
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnLoginAdmin = new Button();
            txtSenhaAdm = new TextBox();
            btnReturn = new Button();
            txtUserAdm = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Goldenrod;
            label1.Font = new Font("Leelawadee UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(578, 21);
            label1.Name = "label1";
            label1.Size = new Size(191, 45);
            label1.TabIndex = 0;
            label1.Text = "Login ADM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Goldenrod;
            label2.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(581, 100);
            label2.Name = "label2";
            label2.Size = new Size(86, 30);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Goldenrod;
            label3.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(581, 222);
            label3.Name = "label3";
            label3.Size = new Size(72, 30);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // btnLoginAdmin
            // 
            btnLoginAdmin.BackColor = Color.White;
            btnLoginAdmin.FlatStyle = FlatStyle.Popup;
            btnLoginAdmin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoginAdmin.ForeColor = Color.Black;
            btnLoginAdmin.ImeMode = ImeMode.NoControl;
            btnLoginAdmin.Location = new Point(566, 356);
            btnLoginAdmin.Name = "btnLoginAdmin";
            btnLoginAdmin.Size = new Size(228, 57);
            btnLoginAdmin.TabIndex = 3;
            btnLoginAdmin.Text = "Login";
            btnLoginAdmin.UseVisualStyleBackColor = false;
            btnLoginAdmin.Click += btnLoginAdmin_Click_2;
            // 
            // txtSenhaAdm
            // 
            txtSenhaAdm.Location = new Point(581, 283);
            txtSenhaAdm.Name = "txtSenhaAdm";
            txtSenhaAdm.PasswordChar = '*';
            txtSenhaAdm.Size = new Size(184, 23);
            txtSenhaAdm.TabIndex = 2;
            txtSenhaAdm.UseSystemPasswordChar = true;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(173, 11, 0);
            btnReturn.BackgroundImage = Properties.Resources._688879_arrows_512x512;
            btnReturn.BackgroundImageLayout = ImageLayout.Stretch;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnReturn.ForeColor = Color.Black;
            btnReturn.Location = new Point(10, 9);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(56, 40);
            btnReturn.TabIndex = 4;
            btnReturn.TextAlign = ContentAlignment.TopLeft;
            btnReturn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // txtUserAdm
            // 
            txtUserAdm.Location = new Point(581, 166);
            txtUserAdm.Name = "txtUserAdm";
            txtUserAdm.Size = new Size(184, 23);
            txtUserAdm.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -26);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(423, 553);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Goldenrod;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(494, 9);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(373, 487);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // AdminLogin
            // 
            AcceptButton = btnLoginAdmin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(173, 11, 0);
            ClientSize = new Size(929, 505);
            Controls.Add(btnReturn);
            Controls.Add(txtUserAdm);
            Controls.Add(txtSenhaAdm);
            Controls.Add(btnLoginAdmin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnLoginAdmin;
        private TextBox txtSenhaAdm;
        private Button btnReturn;
        private MaskedTextBox txtUserAdm;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}