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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoginFunc = new System.Windows.Forms.Button();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.txtDtNasc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(309, 119);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(133, 23);
            this.txtLogin.TabIndex = 2;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(309, 178);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(133, 23);
            this.txtCpf.TabIndex = 3;
            this.txtCpf.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(284, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cadastro";
            // 
            // btnLoginFunc
            // 
            this.btnLoginFunc.Location = new System.Drawing.Point(309, 358);
            this.btnLoginFunc.Name = "btnLoginFunc";
            this.btnLoginFunc.Size = new System.Drawing.Size(133, 39);
            this.btnLoginFunc.TabIndex = 7;
            this.btnLoginFunc.Text = "Criar Senha";
            this.btnLoginFunc.UseVisualStyleBackColor = true;
            this.btnLoginFunc.Click += new System.EventHandler(this.btnLoginFunc_Click);
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(309, 289);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(133, 23);
            this.txtContato.TabIndex = 11;
            // 
            // txtDtNasc
            // 
            this.txtDtNasc.Location = new System.Drawing.Point(309, 230);
            this.txtDtNasc.Name = "txtDtNasc";
            this.txtDtNasc.Size = new System.Drawing.Size(133, 23);
            this.txtDtNasc.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contato";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Data Nascimento";
            // 
            // FuncionarioCadLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.txtDtNasc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLoginFunc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FuncionarioCadLog";
            this.Text = "FuncionarioCadLog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtLogin;
        private TextBox txtCpf;
        private Label label3;
        private Button btnLoginFunc;
        private TextBox txtContato;
        private TextBox txtDtNasc;
        private Label label5;
        private Label label6;
    }
}