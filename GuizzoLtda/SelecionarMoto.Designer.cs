namespace GuizzoLtda
{
    partial class SelecionarMoto
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
            dgSelectMoto = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgSelectMoto).BeginInit();
            SuspendLayout();
            // 
            // dgSelectMoto
            // 
            dgSelectMoto.AllowUserToAddRows = false;
            dgSelectMoto.AllowUserToDeleteRows = false;
            dgSelectMoto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSelectMoto.Dock = DockStyle.Fill;
            dgSelectMoto.Location = new Point(0, 0);
            dgSelectMoto.Name = "dgSelectMoto";
            dgSelectMoto.ReadOnly = true;
            dgSelectMoto.RowTemplate.Height = 25;
            dgSelectMoto.Size = new Size(800, 450);
            dgSelectMoto.TabIndex = 0;
            dgSelectMoto.CellContentDoubleClick += dgSelectMoto_CellContentDoubleClick;
            dgSelectMoto.CellDoubleClick += dgSelectMoto_CellDoubleClick;
            // 
            // SelecionarMoto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgSelectMoto);
            Name = "SelecionarMoto";
            Text = "SelecionarMoto";
            Load += SelecionarMoto_Load;
            ((System.ComponentModel.ISupportInitialize)dgSelectMoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgSelectMoto;
    }
}