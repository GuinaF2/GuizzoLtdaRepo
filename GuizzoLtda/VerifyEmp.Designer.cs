namespace GuizzoLtda
{
    partial class VerifyEmp
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
            txtRazaoSoc = new TextBox();
            btnConfirmar = new Button();
            txtCnpj = new TextBox();
            labelCnpj = new Label();
            txtInscriEstad = new TextBox();
            labelInscEstad = new Label();
            dgVerEmp = new DataGridView();
            returnBtn = new Button();
            btnMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgVerEmp).BeginInit();
            SuspendLayout();
            // 
            // labelRazaoSoc
            // 
            labelRazaoSoc.AutoSize = true;
            labelRazaoSoc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelRazaoSoc.Location = new Point(40, 120);
            labelRazaoSoc.Name = "labelRazaoSoc";
            labelRazaoSoc.Size = new Size(97, 21);
            labelRazaoSoc.TabIndex = 0;
            labelRazaoSoc.Text = "Razão Social";
            // 
            // txtRazaoSoc
            // 
            txtRazaoSoc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRazaoSoc.Location = new Point(40, 151);
            txtRazaoSoc.Name = "txtRazaoSoc";
            txtRazaoSoc.Size = new Size(100, 29);
            txtRazaoSoc.TabIndex = 1;
            txtRazaoSoc.Text = " ";
            txtRazaoSoc.Click += txtRazaoSoc_Click;
            txtRazaoSoc.TextChanged += txtRazaoSoc_TextChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.ForeColor = SystemColors.ControlText;
            btnConfirmar.Location = new Point(40, 331);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(148, 36);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += button1_Click;
            // 
            // txtCnpj
            // 
            txtCnpj.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCnpj.Location = new Point(40, 82);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(100, 29);
            txtCnpj.TabIndex = 4;
            // 
            // labelCnpj
            // 
            labelCnpj.AutoSize = true;
            labelCnpj.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCnpj.Location = new Point(40, 51);
            labelCnpj.Name = "labelCnpj";
            labelCnpj.Size = new Size(46, 21);
            labelCnpj.TabIndex = 3;
            labelCnpj.Text = "CNPJ";
            // 
            // txtInscriEstad
            // 
            txtInscriEstad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtInscriEstad.Location = new Point(40, 226);
            txtInscriEstad.Name = "txtInscriEstad";
            txtInscriEstad.Size = new Size(100, 29);
            txtInscriEstad.TabIndex = 6;
            // 
            // labelInscEstad
            // 
            labelInscEstad.AutoSize = true;
            labelInscEstad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelInscEstad.Location = new Point(40, 195);
            labelInscEstad.Name = "labelInscEstad";
            labelInscEstad.Size = new Size(133, 21);
            labelInscEstad.TabIndex = 5;
            labelInscEstad.Text = "Inscrição Estadual";
            // 
            // dgVerEmp
            // 
            dgVerEmp.AllowUserToAddRows = false;
            dgVerEmp.AllowUserToDeleteRows = false;
            dgVerEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVerEmp.Location = new Point(146, 107);
            dgVerEmp.Name = "dgVerEmp";
            dgVerEmp.ReadOnly = true;
            dgVerEmp.RowTemplate.Height = 25;
            dgVerEmp.Size = new Size(643, 260);
            dgVerEmp.TabIndex = 7;
            dgVerEmp.Visible = false;
            dgVerEmp.CellContentClick += dataGridView1_CellContentClick;
            dgVerEmp.Click += dgVerEmp_Click;
            // 
            // returnBtn
            // 
            returnBtn.BackColor = SystemColors.Control;
            returnBtn.BackgroundImage = Properties.Resources._688879_arrows_512x512;
            returnBtn.BackgroundImageLayout = ImageLayout.Stretch;
            returnBtn.Location = new Point(0, 0);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(33, 36);
            returnBtn.TabIndex = 8;
            returnBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            returnBtn.UseVisualStyleBackColor = false;
            returnBtn.Visible = false;
            returnBtn.Click += button1_Click_1;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = SystemColors.Control;
            btnMenu.BackgroundImage = Properties.Resources._688879_arrows_512x512;
            btnMenu.BackgroundImageLayout = ImageLayout.Stretch;
            btnMenu.Location = new Point(0, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(33, 36);
            btnMenu.TabIndex = 9;
            btnMenu.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // VerifyEmp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(btnMenu);
            Controls.Add(returnBtn);
            Controls.Add(dgVerEmp);
            Controls.Add(txtInscriEstad);
            Controls.Add(labelInscEstad);
            Controls.Add(txtCnpj);
            Controls.Add(labelCnpj);
            Controls.Add(btnConfirmar);
            Controls.Add(txtRazaoSoc);
            Controls.Add(labelRazaoSoc);
            Name = "VerifyEmp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerifyEmp";
            Load += VerifyEmp_Load;
            ((System.ComponentModel.ISupportInitialize)dgVerEmp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRazaoSoc;
        private TextBox txtRazaoSoc;
        private Button btnConfirmar;
        private TextBox txtCnpj;
        private Label labelCnpj;
        private TextBox txtInscriEstad;
        private Label labelInscEstad;
        private DataGridView dgVerEmp;
        private Button returnBtn;
        private Button btnMenu;
    }
}