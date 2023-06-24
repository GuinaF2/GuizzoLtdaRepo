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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(173, 11, 0);
            btnConfirmar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.ForeColor = Color.Goldenrod;
            btnConfirmar.Location = new Point(590, 200);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(191, 42);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += button1_Click;
            // 
            // labeltipo
            // 
            labeltipo.AutoSize = true;
            labeltipo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labeltipo.ForeColor = Color.Goldenrod;
            labeltipo.Location = new Point(60, 15);
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
            labeldesc.Location = new Point(60, 82);
            labeldesc.Name = "labeldesc";
            labeldesc.Size = new Size(99, 25);
            labeldesc.TabIndex = 2;
            labeldesc.Text = "Descrição ";
            labeldesc.Click += labeldesc_Click;
            // 
            // cbTipoSolicit
            // 
            cbTipoSolicit.FormattingEnabled = true;
            cbTipoSolicit.Items.AddRange(new object[] { "Manutenção", "Requisitar Processos", "Atualização de Dados" });
            cbTipoSolicit.Location = new Point(60, 51);
            cbTipoSolicit.Name = "cbTipoSolicit";
            cbTipoSolicit.Size = new Size(121, 23);
            cbTipoSolicit.TabIndex = 3;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(60, 118);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(491, 224);
            txtDescricao.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(607, -3);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Goldenrod;
            button1.BackgroundImage = Properties.Resources._688879_arrows_512x512;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(0, -3);
            button1.Name = "button1";
            button1.Size = new Size(54, 43);
            button1.TabIndex = 6;
            button1.TextImageRelation = TextImageRelation.TextAboveImage;
            button1.UseVisualStyleBackColor = false;
            // 
            // FuncionarioSolicit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(txtDescricao);
            Controls.Add(cbTipoSolicit);
            Controls.Add(labeldesc);
            Controls.Add(labeltipo);
            Controls.Add(btnConfirmar);
            ForeColor = SystemColors.Highlight;
            Name = "FuncionarioSolicit";
            Text = "Funcionario";
            Load += FuncionarioSolicit_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmar;
        private Label labeltipo;
        private Label labeldesc;
        private ComboBox cbTipoSolicit;
        private TextBox txtDescricao;
        private PictureBox pictureBox1;
        private Button button1;
    }
}