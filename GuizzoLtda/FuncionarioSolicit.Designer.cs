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
            btnConfirmar = new Button();
            labeltipo = new Label();
            labeldesc = new Label();
            cbTipoSolicit = new ComboBox();
            txtDescricao = new TextBox();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(309, 397);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(185, 41);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += button1_Click;
            // 
            // labeltipo
            // 
            labeltipo.AutoSize = true;
            labeltipo.Location = new Point(309, 117);
            labeltipo.Name = "labeltipo";
            labeltipo.Size = new Size(106, 15);
            labeltipo.TabIndex = 1;
            labeltipo.Text = "Tipo de Solicitação";
            // 
            // labeldesc
            // 
            labeldesc.AutoSize = true;
            labeldesc.Location = new Point(315, 191);
            labeldesc.Name = "labeldesc";
            labeldesc.Size = new Size(61, 15);
            labeldesc.TabIndex = 2;
            labeldesc.Text = "Descrição ";
            // 
            // cbTipoSolicit
            // 
            cbTipoSolicit.FormattingEnabled = true;
            cbTipoSolicit.Items.AddRange(new object[] { "Manutenção", "Requisitar Processos", "Atualização de Dados" });
            cbTipoSolicit.Location = new Point(311, 144);
            cbTipoSolicit.Name = "cbTipoSolicit";
            cbTipoSolicit.Size = new Size(121, 23);
            cbTipoSolicit.TabIndex = 3;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(247, 224);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(290, 138);
            txtDescricao.TabIndex = 4;
            // 
            // FuncionarioSolicit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDescricao);
            Controls.Add(cbTipoSolicit);
            Controls.Add(labeldesc);
            Controls.Add(labeltipo);
            Controls.Add(btnConfirmar);
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
    }
}