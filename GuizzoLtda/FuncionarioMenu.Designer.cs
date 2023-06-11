namespace GuizzoLtda
{
    partial class FuncionarioMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuncionarioMenu));
            toolStrip1 = new ToolStrip();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton17 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton16 = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButton15 = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripButton14 = new ToolStripButton();
            pictureBox1 = new PictureBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton2, toolStripSeparator1, toolStripButton17, toolStripSeparator2, toolStripButton16, toolStripSeparator3, toolStripButton15, toolStripSeparator4, toolStripButton14 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources._688879_arrows_512x512;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripButton17
            // 
            toolStripButton17.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton17.Image = (Image)resources.GetObject("toolStripButton17.Image");
            toolStripButton17.ImageTransparentColor = Color.Magenta;
            toolStripButton17.Name = "toolStripButton17";
            toolStripButton17.Size = new Size(83, 22);
            toolStripButton17.Text = "Emissão NF-E";
            toolStripButton17.TextImageRelation = TextImageRelation.TextAboveImage;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripButton16
            // 
            toolStripButton16.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton16.Image = (Image)resources.GetObject("toolStripButton16.Image");
            toolStripButton16.ImageTransparentColor = Color.Magenta;
            toolStripButton16.Name = "toolStripButton16";
            toolStripButton16.Size = new Size(110, 22);
            toolStripButton16.Text = "Confirmar Pedidos";
            toolStripButton16.TextImageRelation = TextImageRelation.TextAboveImage;
            toolStripButton16.Click += toolStripButton16_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // toolStripButton15
            // 
            toolStripButton15.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton15.Image = (Image)resources.GetObject("toolStripButton15.Image");
            toolStripButton15.ImageTransparentColor = Color.Magenta;
            toolStripButton15.Name = "toolStripButton15";
            toolStripButton15.Size = new Size(112, 22);
            toolStripButton15.Text = "Solicitar Devolução";
            toolStripButton15.TextImageRelation = TextImageRelation.TextAboveImage;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // toolStripButton14
            // 
            toolStripButton14.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton14.Image = (Image)resources.GetObject("toolStripButton14.Image");
            toolStripButton14.ImageTransparentColor = Color.Magenta;
            toolStripButton14.Name = "toolStripButton14";
            toolStripButton14.Size = new Size(93, 22);
            toolStripButton14.Text = "Verificar Cliente";
            toolStripButton14.TextImageRelation = TextImageRelation.TextAboveImage;
            toolStripButton14.Click += toolStripButton14_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(428, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(372, 450);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FuncionarioMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(pictureBox1);
            Name = "FuncionarioMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += FuncionarioMenu_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripSplitButton toolStripSplitButton2;
        private ToolStripSplitButton toolStripSplitButton4;
        private ToolStripSplitButton toolStripSplitButton3;
        private ToolStripButton toolStripButton17;
        private ToolStripButton toolStripButton16;
        private ToolStripButton toolStripButton15;
        private ToolStripButton toolStripButton14;
        private PictureBox pictureBox1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolStripButton2;
    }
}