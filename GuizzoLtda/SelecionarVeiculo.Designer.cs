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
            this.dgSelectVeiculo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgSelectVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSelectVeiculo
            // 
            this.dgSelectVeiculo.AllowUserToAddRows = false;
            this.dgSelectVeiculo.AllowUserToDeleteRows = false;
            this.dgSelectVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSelectVeiculo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSelectVeiculo.Location = new System.Drawing.Point(0, 0);
            this.dgSelectVeiculo.Name = "dgSelectVeiculo";
            this.dgSelectVeiculo.ReadOnly = true;
            this.dgSelectVeiculo.RowHeadersWidth = 51;
            this.dgSelectVeiculo.RowTemplate.Height = 25;
            this.dgSelectVeiculo.Size = new System.Drawing.Size(929, 505);
            this.dgSelectVeiculo.TabIndex = 0;
            // 
            // SelecionarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 505);
            this.Controls.Add(this.dgSelectVeiculo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelecionarVeiculo";
            this.Text = "SelecionarVeiculo";
            ((System.ComponentModel.ISupportInitialize)(this.dgSelectVeiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgSelectVeiculo;
    }
}