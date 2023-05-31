﻿namespace GuizzoLtda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoginAdmin = new System.Windows.Forms.Button();
            this.txtSenhaAdm = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtUserAdm = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(275, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login ADM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(275, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(275, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha";
            // 
            // btnLoginAdmin
            // 
            this.btnLoginAdmin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoginAdmin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLoginAdmin.Location = new System.Drawing.Point(260, 363);
            this.btnLoginAdmin.Name = "btnLoginAdmin";
            this.btnLoginAdmin.Size = new System.Drawing.Size(228, 57);
            this.btnLoginAdmin.TabIndex = 3;
            this.btnLoginAdmin.Text = "Login";
            this.btnLoginAdmin.UseVisualStyleBackColor = true;
            this.btnLoginAdmin.Click += new System.EventHandler(this.btnLoginAdmin_Click);
            // 
            // txtSenhaAdm
            // 
            this.txtSenhaAdm.Location = new System.Drawing.Point(275, 274);
            this.txtSenhaAdm.Name = "txtSenhaAdm";
            this.txtSenhaAdm.PasswordChar = '*';
            this.txtSenhaAdm.Size = new System.Drawing.Size(194, 23);
            this.txtSenhaAdm.TabIndex = 2;
            this.txtSenhaAdm.UseSystemPasswordChar = true;
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundImage = global::GuizzoLtda.Properties.Resources._688879_arrows_512x512;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Location = new System.Drawing.Point(0, -1);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(54, 54);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // txtUserAdm
            // 
            this.txtUserAdm.Location = new System.Drawing.Point(275, 181);
            this.txtUserAdm.Name = "txtUserAdm";
            this.txtUserAdm.Size = new System.Drawing.Size(194, 23);
            this.txtUserAdm.TabIndex = 5;
            // 
            // AdminLogin
            // 
            this.AcceptButton = this.btnLoginAdmin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUserAdm);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtSenhaAdm);
            this.Controls.Add(this.btnLoginAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnLoginAdmin;
        private TextBox txtSenhaAdm;
        private Button btnReturn;
        private MaskedTextBox txtUserAdm;
    }
}