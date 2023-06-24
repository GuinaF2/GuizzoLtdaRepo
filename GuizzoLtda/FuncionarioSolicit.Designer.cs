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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.labeltipo = new System.Windows.Forms.Label();
            this.labeldesc = new System.Windows.Forms.Label();
            this.cbTipoSolicit = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(11)))), ((int)(((byte)(0)))));
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnConfirmar.Location = new System.Drawing.Point(590, 200);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(191, 42);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // labeltipo
            // 
            this.labeltipo.AutoSize = true;
            this.labeltipo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeltipo.ForeColor = System.Drawing.Color.Goldenrod;
            this.labeltipo.Location = new System.Drawing.Point(60, 15);
            this.labeltipo.Name = "labeltipo";
            this.labeltipo.Size = new System.Drawing.Size(171, 25);
            this.labeltipo.TabIndex = 1;
            this.labeltipo.Text = "Tipo de Solicitação";
            // 
            // labeldesc
            // 
            this.labeldesc.AutoSize = true;
            this.labeldesc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeldesc.ForeColor = System.Drawing.Color.Goldenrod;
            this.labeldesc.Location = new System.Drawing.Point(60, 82);
            this.labeldesc.Name = "labeldesc";
            this.labeldesc.Size = new System.Drawing.Size(99, 25);
            this.labeldesc.TabIndex = 2;
            this.labeldesc.Text = "Descrição ";
            // 
            // cbTipoSolicit
            // 
            this.cbTipoSolicit.FormattingEnabled = true;
            this.cbTipoSolicit.Items.AddRange(new object[] {
            "Manutenção",
            "Requisitar Processos",
            "Atualização de Dados"});
            this.cbTipoSolicit.Location = new System.Drawing.Point(60, 51);
            this.cbTipoSolicit.Name = "cbTipoSolicit";
            this.cbTipoSolicit.Size = new System.Drawing.Size(121, 23);
            this.cbTipoSolicit.TabIndex = 3;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(60, 118);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(491, 224);
            this.txtDescricao.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(607, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FuncionarioSolicit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.cbTipoSolicit);
            this.Controls.Add(this.labeldesc);
            this.Controls.Add(this.labeltipo);
            this.Controls.Add(this.btnConfirmar);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FuncionarioSolicit";
            this.Text = "Funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnConfirmar;
        private Label labeltipo;
        private Label labeldesc;
        private ComboBox cbTipoSolicit;
        private TextBox txtDescricao;
        private PictureBox pictureBox1;
    }
}