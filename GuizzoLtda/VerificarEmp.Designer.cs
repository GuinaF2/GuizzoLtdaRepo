namespace GuizzoLtda
{
    partial class VerificarEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerificarEmp));
            this.labelCnpj = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.returnBtn = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.dgVerEmp = new System.Windows.Forms.DataGridView();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVerEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCnpj
            // 
            this.labelCnpj.AutoSize = true;
            this.labelCnpj.Location = new System.Drawing.Point(48, 64);
            this.labelCnpj.Name = "labelCnpj";
            this.labelCnpj.Size = new System.Drawing.Size(32, 15);
            this.labelCnpj.TabIndex = 1;
            this.labelCnpj.Text = "Cnpj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(72, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Verificar Cliente";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(48, 91);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(100, 23);
            this.txtCnpj.TabIndex = 5;
            // 
            // returnBtn
            // 
            this.returnBtn.BackgroundImage = global::GuizzoLtda.Properties.Resources._688879_arrows_512x512;
            this.returnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.returnBtn.Location = new System.Drawing.Point(0, 1);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(39, 38);
            this.returnBtn.TabIndex = 7;
            this.returnBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.returnBtn.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImage = global::GuizzoLtda.Properties.Resources._688879_arrows_512x512;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.Location = new System.Drawing.Point(0, 1);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(39, 38);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // dgVerEmp
            // 
            this.dgVerEmp.AllowUserToAddRows = false;
            this.dgVerEmp.AllowUserToDeleteRows = false;
            this.dgVerEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVerEmp.Location = new System.Drawing.Point(72, 120);
            this.dgVerEmp.Name = "dgVerEmp";
            this.dgVerEmp.ReadOnly = true;
            this.dgVerEmp.RowHeadersWidth = 51;
            this.dgVerEmp.RowTemplate.Height = 25;
            this.dgVerEmp.Size = new System.Drawing.Size(665, 244);
            this.dgVerEmp.TabIndex = 9;
            this.dgVerEmp.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(48, 339);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(179, 47);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // VerificarEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 505);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelCnpj);
            this.Controls.Add(this.dgVerEmp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerificarEmp";
            this.Text = "VerificarEmp";
            ((System.ComponentModel.ISupportInitialize)(this.dgVerEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelRazaoSoc;
        private Label labelCnpj;
        private Label labelInscEstad;
        private Label label4;
        private TextBox txtRazaoSoc;
        private TextBox txtCnpj;
        private TextBox txtInscriEstad;
        private Button returnBtn;
        private Button btnMenu;
        private DataGridView dgVerEmp;
        private Button btnConfirmar;
    }
}