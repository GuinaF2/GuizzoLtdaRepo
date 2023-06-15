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
            btnDevolucao = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            btnVerifyEmp = new ToolStripButton();
            pbFotoMenuFunc = new PictureBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotoMenuFunc).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton2, toolStripSeparator1, toolStripButton17, toolStripSeparator2, btnConfirmarPedi, toolStripSeparator3, btnDevolucao, toolStripSeparator4, btnVerifyEmp });
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
            // btnDevolucao
            // 
            btnDevolucao.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDevolucao.Image = (Image)resources.GetObject("btnDevolucao.Image");
            btnDevolucao.ImageTransparentColor = Color.Magenta;
            btnDevolucao.Name = "btnDevolucao";
            btnDevolucao.Size = new Size(112, 22);
            btnDevolucao.Text = "Solicitar Devolução";
            btnDevolucao.TextImageRelation = TextImageRelation.TextAboveImage;
            btnDevolucao.Click += toolStripButton15_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // btnVerifyEmp
            // 
            btnVerifyEmp.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnVerifyEmp.Image = (Image)resources.GetObject("btnVerifyEmp.Image");
            btnVerifyEmp.ImageTransparentColor = Color.Magenta;
            btnVerifyEmp.Name = "btnVerifyEmp";
            btnVerifyEmp.Size = new Size(93, 22);
            btnVerifyEmp.Text = "Verificar Cliente";
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
        private ToolStripButton btnDevolucao;
        private ToolStripButton btnVerifyEmp;
        private PictureBox pbFotoMenuFunc;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolStripButton2;
    }
}