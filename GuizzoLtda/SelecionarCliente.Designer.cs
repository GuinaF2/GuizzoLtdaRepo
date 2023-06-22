namespace GuizzoLtda
{
    partial class SelecionarCliente
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
            dgCliente = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgCliente).BeginInit();
            SuspendLayout();
            // 
            // dgCliente
            // 
            dgCliente.AllowUserToAddRows = false;
            dgCliente.AllowUserToDeleteRows = false;
            dgCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCliente.Dock = DockStyle.Fill;
            dgCliente.Location = new Point(0, 0);
            dgCliente.Name = "dgCliente";
            dgCliente.ReadOnly = true;
            dgCliente.RowTemplate.Height = 25;
            dgCliente.Size = new Size(800, 450);
            dgCliente.TabIndex = 0;
            dgCliente.CellDoubleClick += dgVeiculo_CellDoubleClick;
            // 
            // SelecionarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgCliente);
            Name = "SelecionarCliente";
            Text = "SelecionarCliente";
            Load += SelecionarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgCliente;
    }
}