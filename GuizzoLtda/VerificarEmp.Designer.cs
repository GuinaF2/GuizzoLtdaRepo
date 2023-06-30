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
            labelCnpj = new Label();
            label4 = new Label();
            txtCnpj = new TextBox();
            dgVerEmp = new DataGridView();
            btnConfirmar = new Button();
            toolStrip1 = new ToolStrip();
            btnMenu = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            returnBtn = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dgVerEmp).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelCnpj
            // 
            labelCnpj.AutoSize = true;
            labelCnpj.FlatStyle = FlatStyle.Popup;
            labelCnpj.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCnpj.Location = new Point(72, 112);
            labelCnpj.Name = "labelCnpj";
            labelCnpj.Size = new Size(55, 25);
            labelCnpj.TabIndex = 1;
            labelCnpj.Text = "CNPJ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(61, 27);
            label4.Name = "label4";
            label4.Size = new Size(202, 37);
            label4.TabIndex = 3;
            label4.Text = "Verificar Cliente";
            // 
            // txtCnpj
            // 
            txtCnpj.BackColor = Color.Black;
            txtCnpj.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCnpj.ForeColor = Color.Goldenrod;
            txtCnpj.Location = new Point(72, 140);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(176, 27);
            txtCnpj.TabIndex = 5;
            txtCnpj.KeyPress += txtCnpj_KeyPress;
            // 
            // dgVerEmp
            // 
            dgVerEmp.AllowUserToAddRows = false;
            dgVerEmp.AllowUserToDeleteRows = false;
            dgVerEmp.BackgroundColor = SystemColors.ActiveCaptionText;
            dgVerEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVerEmp.GridColor = Color.Goldenrod;
            dgVerEmp.Location = new Point(72, 140);
            dgVerEmp.Name = "dgVerEmp";
            dgVerEmp.ReadOnly = true;
            dgVerEmp.RowHeadersWidth = 51;
            dgVerEmp.RowTemplate.Height = 25;
            dgVerEmp.Size = new Size(665, 244);
            dgVerEmp.TabIndex = 9;
            dgVerEmp.Visible = false;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.Black;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmar.ForeColor = Color.Goldenrod;
            btnConfirmar.Location = new Point(72, 355);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(235, 68);
            btnConfirmar.TabIndex = 10;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Maroon;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnMenu, toolStripSeparator1, returnBtn });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(929, 27);
            toolStrip1.TabIndex = 11;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenu.ForeColor = Color.Goldenrod;
            btnMenu.Image = Properties.Resources._688879_arrows_512x512;
            btnMenu.ImageTransparentColor = Color.Magenta;
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(69, 24);
            btnMenu.Text = "Menu";
            btnMenu.Click += btnMenu_Click_2;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // returnBtn
            // 
            returnBtn.Enabled = false;
            returnBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            returnBtn.ForeColor = Color.Goldenrod;
            returnBtn.Image = Properties.Resources.FlechaReturn;
            returnBtn.ImageTransparentColor = Color.Magenta;
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(91, 24);
            returnBtn.Text = "Retornar";
            returnBtn.Click += returnBtn_Click_1;
            // 
            // VerificarEmp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(929, 505);
            Controls.Add(toolStrip1);
            Controls.Add(btnConfirmar);
            Controls.Add(txtCnpj);
            Controls.Add(label4);
            Controls.Add(labelCnpj);
            Controls.Add(dgVerEmp);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VerificarEmp";
            Text = "VerificarEmp";
            Load += VerificarEmp_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgVerEmp).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private DataGridView dgVerEmp;
        private Button btnConfirmar;
        private ToolStrip toolStrip1;
        private ToolStripButton btnMenu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton returnBtn;
    }
}