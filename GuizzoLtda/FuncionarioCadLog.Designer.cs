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
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(273, 128);
            label1.Name = "label1";
            label1.Size = new Size(70, 30);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.Location = new Point(273, 161);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(184, 35);
            txtLogin.TabIndex = 2;
            txtLogin.TextChanged += txtLogin_TextChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(307, 25);
            label3.Name = "label3";
            label3.Size = new Size(113, 50);
            label3.TabIndex = 4;
            label3.Text = "Login";
            // 
            // btnLoginFunc
            // 
            btnLoginFunc.FlatAppearance.BorderSize = 0;
            btnLoginFunc.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoginFunc.Location = new Point(260, 343);
            btnLoginFunc.Name = "btnLoginFunc";
            btnLoginFunc.Size = new Size(218, 66);
            btnLoginFunc.TabIndex = 4;
            btnLoginFunc.Text = "Fazer Login";
            btnLoginFunc.UseVisualStyleBackColor = true;
            btnLoginFunc.Click += btnLoginFunc_Click_1;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(273, 232);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(184, 35);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.TextChanged += txtSenha_TextChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(273, 199);
            label4.Name = "label4";
            label4.Size = new Size(70, 30);
            label4.TabIndex = 13;
            label4.Text = "Senha";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 14;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources._688879_arrows_512x512;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // FuncionarioCadLog
            // 
            AcceptButton = btnLoginFunc;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(txtSenha);
            Controls.Add(label4);
            Controls.Add(btnLoginFunc);
            Controls.Add(label3);
            Controls.Add(txtLogin);
            Controls.Add(label1);
            Name = "FuncionarioCadLog";
            Text = "FuncionarioCadLog";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
    }
}