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
            btnConfirmarPedi = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnVerifyEmp = new ToolStripButton();
            pbFotoMenuFunc = new PictureBox();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripButton3 = new ToolStripButton();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotoMenuFunc).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton2, toolStripSeparator1, toolStripButton17, toolStripSeparator2, btnConfirmarPedi, toolStripSeparator3, btnVerifyEmp, toolStripSeparator5, toolStripButton3 });
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
            toolStripButton17.Size = new Size(125, 22);
            toolStripButton17.Text = "Emissão Documentos";
            toolStripButton17.TextImageRelation = TextImageRelation.TextAboveImage;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // btnConfirmarPedi
            // 
            btnConfirmarPedi.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnConfirmarPedi.Image = (Image)resources.GetObject("btnConfirmarPedi.Image");
            btnConfirmarPedi.ImageTransparentColor = Color.Magenta;
            btnConfirmarPedi.Name = "btnConfirmarPedi";
            btnConfirmarPedi.Size = new Size(110, 22);
            btnConfirmarPedi.Text = "Confirmar Pedidos";
            btnConfirmarPedi.TextImageRelation = TextImageRelation.TextAboveImage;
            btnConfirmarPedi.Click += toolStripButton16_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // btnVerifyEmp
            // 
            btnVerifyEmp.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnVerifyEmp.Image = (Image)resources.GetObject("btnVerifyEmp.Image");
            btnVerifyEmp.ImageTransparentColor = Color.Magenta;
            btnVerifyEmp.Name = "btnVerifyEmp";
            btnVerifyEmp.Size = new Size(102, 22);
            btnVerifyEmp.Text = "Encontrar Cliente";
            btnVerifyEmp.TextImageRelation = TextImageRelation.TextAboveImage;
            btnVerifyEmp.Click += toolStripButton14_Click;
            // 
            // pbFotoMenuFunc
            // 
            pbFotoMenuFunc.BorderStyle = BorderStyle.Fixed3D;
            pbFotoMenuFunc.Location = new Point(428, 28);
            pbFotoMenuFunc.Name = "pbFotoMenuFunc";
            pbFotoMenuFunc.Size = new Size(372, 422);
            pbFotoMenuFunc.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFotoMenuFunc.TabIndex = 1;
            pbFotoMenuFunc.TabStop = false;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 25);
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(98, 22);
            toolStripButton3.Text = "Verificar Pedidos";
            toolStripButton3.TextImageRelation = TextImageRelation.TextAboveImage;
            // 
            // FuncionarioMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(pbFotoMenuFunc);
            Name = "FuncionarioMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += FuncionarioMenu_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotoMenuFunc).EndInit();
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
        private ToolStripButton btnConfirmarPedi;
        private ToolStripButton btnVerifyEmp;
        private PictureBox pbFotoMenuFunc;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolStripButton3;
    }
}