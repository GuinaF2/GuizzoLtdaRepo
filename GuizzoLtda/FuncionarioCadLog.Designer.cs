﻿namespace GuizzoLtda
{
    partial class FuncionarioCadLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuncionarioCadLog));
            label1 = new Label();
            txtLogin = new TextBox();
            label3 = new Label();
            btnLoginFunc = new Button();
            txtSenha = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            btnreturn = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(221, 116);
            label1.Name = "label1";
            label1.Size = new Size(93, 38);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.Location = new Point(221, 181);
            txtLogin.Margin = new Padding(3, 4, 3, 4);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(210, 42);
            txtLogin.TabIndex = 2;
            txtLogin.TextChanged += txtLogin_TextChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Leelawadee UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(221, 27);
            label3.Name = "label3";
            label3.Size = new Size(150, 62);
            label3.TabIndex = 4;
            label3.Text = "Login";
            // 
            // btnLoginFunc
            // 
            btnLoginFunc.BackColor = Color.Black;
            btnLoginFunc.FlatAppearance.BorderSize = 0;
            btnLoginFunc.FlatStyle = FlatStyle.Popup;
            btnLoginFunc.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoginFunc.ForeColor = Color.White;
            btnLoginFunc.Location = new Point(203, 412);
            btnLoginFunc.Margin = new Padding(3, 4, 3, 4);
            btnLoginFunc.Name = "btnLoginFunc";
            btnLoginFunc.Size = new Size(249, 88);
            btnLoginFunc.TabIndex = 4;
            btnLoginFunc.Text = "Fazer Login";
            btnLoginFunc.UseVisualStyleBackColor = false;
            btnLoginFunc.Click += btnLoginFunc_Click_1;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(221, 319);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(210, 42);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.TextChanged += txtSenha_TextChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(221, 247);
            label4.Name = "label4";
            label4.Size = new Size(93, 38);
            label4.TabIndex = 13;
            label4.Text = "Senha";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(612, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(449, 673);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // btnreturn
            // 
            btnreturn.BackColor = Color.FromArgb(173, 11, 0);
            btnreturn.BackgroundImage = Properties.Resources._688879_arrows_512x512;
            btnreturn.BackgroundImageLayout = ImageLayout.Stretch;
            btnreturn.FlatAppearance.BorderSize = 0;
            btnreturn.FlatStyle = FlatStyle.Flat;
            btnreturn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnreturn.ForeColor = Color.Black;
            btnreturn.Location = new Point(42, 27);
            btnreturn.Margin = new Padding(3, 4, 3, 4);
            btnreturn.Name = "btnreturn";
            btnreturn.Size = new Size(87, 82);
            btnreturn.TabIndex = 17;
            btnreturn.TextAlign = ContentAlignment.TopLeft;
            btnreturn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnreturn.UseVisualStyleBackColor = false;
            btnreturn.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Location = new Point(596, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 673);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // FuncionarioCadLog
            // 
            AcceptButton = btnLoginFunc;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(173, 11, 0);
            ClientSize = new Size(1062, 673);
            Controls.Add(pictureBox2);
            Controls.Add(btnreturn);
            Controls.Add(pictureBox1);
            Controls.Add(txtSenha);
            Controls.Add(label4);
            Controls.Add(btnLoginFunc);
            Controls.Add(label3);
            Controls.Add(txtLogin);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FuncionarioCadLog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FuncionarioCadLog";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLogin;
        private Label label3;
        private Button btnLoginFunc;
        private TextBox txtSenha;
        private Label label4;
        private PictureBox pictureBox1;
        private Button btnreturn;
        private PictureBox pictureBox2;
    }
}