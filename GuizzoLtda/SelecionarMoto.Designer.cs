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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelecionarMoto));
            this.dgSelectMoto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgSelectMoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSelectMoto
            // 
            this.dgSelectMoto.AllowUserToAddRows = false;
            this.dgSelectMoto.AllowUserToDeleteRows = false;
            this.dgSelectMoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSelectMoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSelectMoto.Location = new System.Drawing.Point(0, 0);
            this.dgSelectMoto.Name = "dgSelectMoto";
            this.dgSelectMoto.ReadOnly = true;
            this.dgSelectMoto.RowTemplate.Height = 25;
            this.dgSelectMoto.Size = new System.Drawing.Size(800, 450);
            this.dgSelectMoto.TabIndex = 0;
            // 
            // SelecionarMoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgSelectMoto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelecionarMoto";
            this.Text = "SelecionarMoto";
            ((System.ComponentModel.ISupportInitialize)(this.dgSelectMoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgSelectMoto;
    }
}