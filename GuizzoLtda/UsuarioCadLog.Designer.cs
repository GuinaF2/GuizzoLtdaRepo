﻿namespace GuizzoLtda
{
    partial class UsuarioCadLog
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(201, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o tipo de Usuário";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 94);
            this.button1.TabIndex = 1;
            this.button1.Text = "Funcionário";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(294, 94);
            this.button2.TabIndex = 2;
            this.button2.Text = "Empresa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // UsuarioCadLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "UsuarioCadLog";
            this.Text = "UsuarioCadLog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}