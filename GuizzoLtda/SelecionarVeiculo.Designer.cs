namespace GuizzoLtda
{
    partial class SelecionarVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelecionarVeiculo));
            dgSelectVeiculo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgSelectVeiculo).BeginInit();
            SuspendLayout();
            // 
            // dgSelectVeiculo
            // 
            dgSelectVeiculo.AllowUserToAddRows = false;
            dgSelectVeiculo.AllowUserToDeleteRows = false;
            dgSelectVeiculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSelectVeiculo.Dock = DockStyle.Fill;
            dgSelectVeiculo.Location = new Point(0, 0);
            dgSelectVeiculo.Name = "dgSelectVeiculo";
            dgSelectVeiculo.ReadOnly = true;
            dgSelectVeiculo.RowHeadersWidth = 51;
            dgSelectVeiculo.RowTemplate.Height = 25;
            dgSelectVeiculo.Size = new Size(929, 505);
            dgSelectVeiculo.TabIndex = 0;
            dgSelectVeiculo.CellDoubleClick += dgSelectVeiculo_CellDoubleClick_1;
            // 
            // SelecionarVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 505);
            Controls.Add(dgSelectVeiculo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SelecionarVeiculo";
            Text = "SelecionarVeiculo";
            Load += SelecionarVeiculo_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgSelectVeiculo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgSelectVeiculo;
    }
}