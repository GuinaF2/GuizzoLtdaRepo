namespace GuizzoLtda
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
            label1 = new Label();
            txtLogin = new TextBox();
            label3 = new Label();
            btnLoginFunc = new Button();
            txtSenha = new TextBox();
            label4 = new Label();
            btnRetornar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(299, 135);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(299, 153);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(133, 23);
            txtLogin.TabIndex = 2;
            txtLogin.TextChanged += txtLogin_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(319, 21);
            label3.Name = "label3";
            label3.Size = new Size(113, 50);
            label3.TabIndex = 4;
            label3.Text = "Login";
            // 
            // btnLoginFunc
            // 
            btnLoginFunc.FlatStyle = FlatStyle.Flat;
            btnLoginFunc.Location = new Point(299, 341);
            btnLoginFunc.Name = "btnLoginFunc";
            btnLoginFunc.Size = new Size(133, 39);
            btnLoginFunc.TabIndex = 7;
            btnLoginFunc.Text = "Fazer Login";
            btnLoginFunc.UseVisualStyleBackColor = true;
            btnLoginFunc.Click += btnLoginFunc_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(299, 224);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(133, 23);
            txtSenha.TabIndex = 14;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(299, 206);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 13;
            label4.Text = "Senha";
            // 
            // btnRetornar
            // 
            btnRetornar.FlatStyle = FlatStyle.Flat;
            btnRetornar.Location = new Point(-3, -2);
            btnRetornar.Name = "btnRetornar";
            btnRetornar.Size = new Size(133, 39);
            btnRetornar.TabIndex = 15;
            btnRetornar.Text = "Retornar";
            btnRetornar.UseVisualStyleBackColor = true;
            btnRetornar.Click += btnRetornar_Click;
            // 
            // FuncionarioCadLog
            // 
            AcceptButton = btnLoginFunc;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRetornar);
            Controls.Add(txtSenha);
            Controls.Add(label4);
            Controls.Add(btnLoginFunc);
            Controls.Add(label3);
            Controls.Add(txtLogin);
            Controls.Add(label1);
            Name = "FuncionarioCadLog";
            Text = "FuncionarioCadLog";
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
        private Button btnRetornar;
    }
}