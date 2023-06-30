namespace GuizzoLtda
{
    partial class FuncionarioSolicit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuncionarioSolicit));
            btnConfirmar = new Button();
            labeltipo = new Label();
            labeldesc = new Label();
            cbTipoSolicit = new ComboBox();
            txtDescricao = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.Black;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmar.ForeColor = Color.Goldenrod;
            btnConfirmar.Location = new Point(261, 363);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(268, 62);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += button1_Click;
            // 
            // labeltipo
            // 
            labeltipo.AutoSize = true;
            labeltipo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labeltipo.ForeColor = Color.Black;
            labeltipo.Location = new Point(142, 9);
            labeltipo.Name = "labeltipo";
            labeltipo.Size = new Size(171, 25);
            labeltipo.TabIndex = 1;
            labeltipo.Text = "Tipo de Solicitação";
            labeltipo.Click += labeltipo_Click;
            // 
            // labeldesc
            // 
            labeldesc.AutoSize = true;
            labeldesc.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labeldesc.ForeColor = Color.Goldenrod;
            labeldesc.Location = new Point(142, 82);
            labeldesc.Name = "labeldesc";
            labeldesc.Size = new Size(99, 25);
            labeldesc.TabIndex = 2;
            labeldesc.Text = "Descrição ";
            labeldesc.Click += labeldesc_Click;
            // 
            // cbTipoSolicit
            // 
            cbTipoSolicit.BackColor = Color.Black;
            cbTipoSolicit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbTipoSolicit.ForeColor = Color.Goldenrod;
            cbTipoSolicit.FormattingEnabled = true;
            cbTipoSolicit.Items.AddRange(new object[] { "Manutenção", "Requisitar Processos", "Atualização de Dados" });
            cbTipoSolicit.Location = new Point(157, 37);
            cbTipoSolicit.Name = "cbTipoSolicit";
            cbTipoSolicit.Size = new Size(121, 28);
            cbTipoSolicit.TabIndex = 3;
            // 
            // txtDescricao
            // 
            txtDescricao.BackColor = Color.Black;
            txtDescricao.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescricao.ForeColor = Color.Goldenrod;
            txtDescricao.Location = new Point(142, 110);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(491, 224);
            txtDescricao.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(173, 11, 0);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(-1, 0);
            button1.Name = "button1";
            button1.Size = new Size(52, 34);
            button1.TabIndex = 6;
            button1.TextImageRelation = TextImageRelation.TextAboveImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // FuncionarioSolicit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(173, 11, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtDescricao);
            Controls.Add(cbTipoSolicit);
            Controls.Add(labeldesc);
            Controls.Add(labeltipo);
            Controls.Add(btnConfirmar);
            ForeColor = SystemColors.Highlight;
            Name = "FuncionarioSolicit";
            Text = "Funcionario";
            Load += FuncionarioSolicit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmar;
        private Label labeltipo;
        private Label labeldesc;
        private ComboBox cbTipoSolicit;
        private TextBox txtDescricao;
        private Button button1;
    }
}