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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUserAdm = new TextBox();
            btnLoginAdmin = new Button();
            txtSenhaAdm = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(275, 35);
            label1.Name = "label1";
            label1.Size = new Size(180, 45);
            label1.TabIndex = 0;
            label1.Text = "Login ADM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(275, 118);
            label2.Name = "label2";
            label2.Size = new Size(83, 30);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(275, 218);
            label3.Name = "label3";
            label3.Size = new Size(70, 30);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // txtUserAdm
            // 
            txtUserAdm.Location = new Point(275, 170);
            txtUserAdm.Name = "txtUserAdm";
            txtUserAdm.Size = new Size(194, 23);
            txtUserAdm.TabIndex = 3;
            // 
            // btnLoginAdmin
            // 
            btnLoginAdmin.Location = new Point(286, 357);
            btnLoginAdmin.Name = "btnLoginAdmin";
            btnLoginAdmin.Size = new Size(157, 54);
            btnLoginAdmin.TabIndex = 4;
            btnLoginAdmin.Text = "Login";
            btnLoginAdmin.UseVisualStyleBackColor = true;
            btnLoginAdmin.Click += btnLoginAdmin_Click;
            // 
            // txtSenhaAdm
            // 
            txtSenhaAdm.Location = new Point(275, 274);
            txtSenhaAdm.Name = "txtSenhaAdm";
            txtSenhaAdm.Size = new Size(194, 23);
            txtSenhaAdm.TabIndex = 5;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSenhaAdm);
            Controls.Add(btnLoginAdmin);
            Controls.Add(txtUserAdm);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminLogin";
            Text = "AdminLogin";
            Load += AdminLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUserAdm;
        private Button btnLoginAdmin;
        private TextBox txtSenhaAdm;
    }
}