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
            labelCnpj = new Label();
            label4 = new Label();
            txtCnpj = new TextBox();
            returnBtn = new Button();
            btnMenu = new Button();
            dgVerEmp = new DataGridView();
            btnConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgVerEmp).BeginInit();
            SuspendLayout();
            // 
            // labelCnpj
            // 
            labelCnpj.AutoSize = true;
            labelCnpj.Location = new Point(55, 85);
            labelCnpj.Name = "labelCnpj";
            labelCnpj.Size = new Size(39, 20);
            labelCnpj.TabIndex = 1;
            labelCnpj.Text = "Cnpj";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(82, 12);
            label4.Name = "label4";
            label4.Size = new Size(223, 41);
            label4.TabIndex = 3;
            label4.Text = "Verificar Cliente";
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(55, 121);
            txtCnpj.Margin = new Padding(3, 4, 3, 4);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(114, 27);
            txtCnpj.TabIndex = 5;
            // 
            // returnBtn
            // 
            returnBtn.BackgroundImage = Properties.Resources._688879_arrows_512x512;
            returnBtn.BackgroundImageLayout = ImageLayout.Stretch;
            returnBtn.Location = new Point(0, 1);
            returnBtn.Margin = new Padding(3, 4, 3, 4);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(45, 51);
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
            btnMenu.Margin = new Padding(3, 4, 3, 4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(45, 51);
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
            dgVerEmp.Location = new Point(82, 160);
            dgVerEmp.Margin = new Padding(3, 4, 3, 4);
            dgVerEmp.Name = "dgVerEmp";
            dgVerEmp.ReadOnly = true;
            dgVerEmp.RowHeadersWidth = 51;
            dgVerEmp.RowTemplate.Height = 25;
            dgVerEmp.Size = new Size(760, 325);
            dgVerEmp.TabIndex = 9;
            dgVerEmp.Visible = false;
            dgVerEmp.CellContentClick += dgVerEmp_CellContentClick;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(55, 452);
            btnConfirmar.Margin = new Padding(3, 4, 3, 4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(205, 63);
            btnConfirmar.TabIndex = 10;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += button1_Click;
            // 
            // VerificarEmp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(btnConfirmar);
            Controls.Add(btnMenu);
            Controls.Add(returnBtn);
            Controls.Add(txtCnpj);
            Controls.Add(label4);
            Controls.Add(labelCnpj);
            Controls.Add(dgVerEmp);
            Margin = new Padding(3, 4, 3, 4);
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