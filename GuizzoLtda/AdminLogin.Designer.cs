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
            label1.Location = new Point(660, 28);
            label1.Name = "label1";
            label1.Size = new Size(234, 54);
            label1.TabIndex = 0;
            label1.Text = "Login ADM";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Goldenrod;
            label2.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(664, 134);
            label2.Name = "label2";
            label2.Size = new Size(111, 38);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Goldenrod;
            label3.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(664, 296);
            label3.Name = "label3";
            label3.Size = new Size(93, 38);
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
            btnLoginAdmin.Location = new Point(647, 475);
            btnLoginAdmin.Margin = new Padding(3, 4, 3, 4);
            btnLoginAdmin.Name = "btnLoginAdmin";
            btnLoginAdmin.Size = new Size(260, 76);
            btnLoginAdmin.TabIndex = 3;
            btnLoginAdmin.Text = "Login";
            btnLoginAdmin.UseVisualStyleBackColor = false;
            btnLoginAdmin.Click += btnLoginAdmin_Click;
            // 
            // txtSenhaAdm
            // 
            txtSenhaAdm.Location = new Point(664, 377);
            txtSenhaAdm.Margin = new Padding(3, 4, 3, 4);
            txtSenhaAdm.Name = "txtSenhaAdm";
            txtSenhaAdm.PasswordChar = '*';
            txtSenhaAdm.Size = new Size(210, 27);
            txtSenhaAdm.TabIndex = 2;
            txtSenhaAdm.UseSystemPasswordChar = true;
            txtSenhaAdm.TextChanged += txtSenhaAdm_TextChanged_1;
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
            btnReturn.Location = new Point(12, 12);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(64, 53);
            btnReturn.TabIndex = 4;
            btnReturn.TextAlign = ContentAlignment.TopLeft;
            btnReturn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click_1;
            // 
            // txtUserAdm
            // 
            txtUserAdm.Location = new Point(664, 221);
            txtUserAdm.Margin = new Padding(3, 4, 3, 4);
            txtUserAdm.Name = "txtUserAdm";
            txtUserAdm.Size = new Size(210, 27);
            txtUserAdm.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(475, 732);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Goldenrod;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(564, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(426, 649);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // AdminLogin
            // 
            AcceptButton = btnLoginAdmin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(173, 11, 0);
            ClientSize = new Size(1062, 673);
            Controls.Add(btnReturn);
            Controls.Add(txtUserAdm);
            Controls.Add(txtSenhaAdm);
            Controls.Add(btnLoginAdmin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            Load += AdminLogin_Load_2;
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