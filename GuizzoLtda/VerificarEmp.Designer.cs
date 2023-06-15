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
            labelRazaoSoc = new Label();
            labelCnpj = new Label();
            labelInscEstad = new Label();
            label4 = new Label();
            txtRazaoSoc = new TextBox();
            txtCnpj = new TextBox();
            txtInscriEstad = new TextBox();
            returnBtn = new Button();
            btnMenu = new Button();
            dgVerEmp = new DataGridView();
            btnConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgVerEmp).BeginInit();
            SuspendLayout();
            // 
            // labelRazaoSoc
            // 
            labelRazaoSoc.AutoSize = true;
            labelRazaoSoc.Location = new Point(45, 60);
            labelRazaoSoc.Name = "labelRazaoSoc";
            labelRazaoSoc.Size = new Size(72, 15);
            labelRazaoSoc.TabIndex = 0;
            labelRazaoSoc.Text = "Razão Social";
            // 
            // labelCnpj
            // 
            labelCnpj.AutoSize = true;
            labelCnpj.Location = new Point(46, 142);
            labelCnpj.Name = "labelCnpj";
            labelCnpj.Size = new Size(32, 15);
            labelCnpj.TabIndex = 1;
            labelCnpj.Text = "Cnpj";
            // 
            // labelInscEstad
            // 
            labelInscEstad.AutoSize = true;
            labelInscEstad.Location = new Point(45, 233);
            labelInscEstad.Name = "labelInscEstad";
            labelInscEstad.Size = new Size(101, 15);
            labelInscEstad.TabIndex = 2;
            labelInscEstad.Text = "Inscrição Estadual";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(72, 9);
            label4.Name = "label4";
            label4.Size = new Size(181, 32);
            label4.TabIndex = 3;
            label4.Text = "Verificar Cliente";
            // 
            // txtRazaoSoc
            // 
            txtRazaoSoc.Location = new Point(46, 91);
            txtRazaoSoc.Name = "txtRazaoSoc";
            txtRazaoSoc.Size = new Size(100, 23);
            txtRazaoSoc.TabIndex = 4;
            txtRazaoSoc.Click += txtRazaoSoc_Click;
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(46, 169);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(100, 23);
            txtCnpj.TabIndex = 5;
            // 
            // txtInscriEstad
            // 
            txtInscriEstad.Location = new Point(46, 267);
            txtInscriEstad.Name = "txtInscriEstad";
            txtInscriEstad.Size = new Size(100, 23);
            txtInscriEstad.TabIndex = 6;
            // 
            // returnBtn
            // 
            returnBtn.BackgroundImage = Properties.Resources._688879_arrows_512x512;
            returnBtn.BackgroundImageLayout = ImageLayout.Stretch;
            returnBtn.Location = new Point(0, 1);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(39, 38);
            returnBtn.TabIndex = 7;
            returnBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            returnBtn.UseVisualStyleBackColor = true;
            returnBtn.Click += returnBtn_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackgroundImage = Properties.Resources._688879_arrows_512x512;
            btnMenu.BackgroundImageLayout = ImageLayout.Stretch;
            btnMenu.Location = new Point(0, 1);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(39, 38);
            btnMenu.TabIndex = 8;
            btnMenu.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // dgVerEmp
            // 
            dgVerEmp.AllowUserToAddRows = false;
            dgVerEmp.AllowUserToDeleteRows = false;
            dgVerEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVerEmp.Location = new Point(72, 120);
            dgVerEmp.Name = "dgVerEmp";
            dgVerEmp.ReadOnly = true;
            dgVerEmp.RowTemplate.Height = 25;
            dgVerEmp.Size = new Size(665, 244);
            dgVerEmp.TabIndex = 9;
            dgVerEmp.Visible = false;
            dgVerEmp.CellContentClick += dgVerEmp_CellContentClick;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(12, 358);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(179, 47);
            btnConfirmar.TabIndex = 10;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += button1_Click;
            // 
            // VerificarEmp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirmar);
            Controls.Add(btnMenu);
            Controls.Add(returnBtn);
            Controls.Add(txtInscriEstad);
            Controls.Add(txtCnpj);
            Controls.Add(txtRazaoSoc);
            Controls.Add(label4);
            Controls.Add(labelInscEstad);
            Controls.Add(labelCnpj);
            Controls.Add(labelRazaoSoc);
            Controls.Add(dgVerEmp);
            Name = "VerificarEmp";
            Text = "VerificarEmp";
            Load += VerificarEmp_Load;
            ((System.ComponentModel.ISupportInitialize)dgVerEmp).EndInit();
            ResumeLayout(false);
            PerformLayout();
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