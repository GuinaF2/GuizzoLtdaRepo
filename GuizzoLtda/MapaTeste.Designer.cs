namespace GuizzoLtda
{
    partial class MapaTeste
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
            MapaBr = new GMap.NET.WindowsForms.GMapControl();
            label1 = new Label();
            txtLat = new TextBox();
            txtLong = new TextBox();
            label2 = new Label();
            button1 = new Button();
            labeldistancia = new Label();
            splitter1 = new Splitter();
            toolStrip1 = new ToolStrip();
            btnReturn = new ToolStripButton();
            btnMarcações = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnClear = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnRota = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            txtEndereco = new TextBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MapaBr
            // 
            MapaBr.Bearing = 0F;
            MapaBr.CanDragMap = true;
            MapaBr.EmptyTileColor = Color.Navy;
            MapaBr.GrayScaleMode = false;
            MapaBr.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            MapaBr.LevelsKeepInMemmory = 5;
            MapaBr.Location = new Point(0, 0);
            MapaBr.Margin = new Padding(3, 4, 3, 4);
            MapaBr.MarkersEnabled = true;
            MapaBr.MaxZoom = 50;
            MapaBr.MinZoom = 5;
            MapaBr.MouseWheelZoomEnabled = true;
            MapaBr.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            MapaBr.Name = "MapaBr";
            MapaBr.NegativeMode = false;
            MapaBr.PolygonsEnabled = true;
            MapaBr.RetryLoadTile = 0;
            MapaBr.RoutesEnabled = true;
            MapaBr.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            MapaBr.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            MapaBr.ShowTileGridLines = false;
            MapaBr.Size = new Size(457, 600);
            MapaBr.TabIndex = 1;
            MapaBr.Zoom = 0D;
            MapaBr.Load += gMapControl1_Load;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(724, 76);
            label1.Name = "label1";
            label1.Size = new Size(114, 37);
            label1.TabIndex = 2;
            label1.Text = "Latitude";
            // 
            // txtLat
            // 
            txtLat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtLat.Location = new Point(724, 124);
            txtLat.Margin = new Padding(3, 4, 3, 4);
            txtLat.Name = "txtLat";
            txtLat.Size = new Size(199, 27);
            txtLat.TabIndex = 3;
            // 
            // txtLong
            // 
            txtLong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtLong.Location = new Point(724, 223);
            txtLong.Margin = new Padding(3, 4, 3, 4);
            txtLong.Name = "txtLong";
            txtLong.Size = new Size(197, 27);
            txtLong.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(724, 179);
            label2.Name = "label2";
            label2.Size = new Size(138, 37);
            label2.TabIndex = 5;
            label2.Text = "Longitude";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(694, 475);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(289, 87);
            button1.TabIndex = 6;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labeldistancia
            // 
            labeldistancia.AutoSize = true;
            labeldistancia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labeldistancia.Location = new Point(634, 269);
            labeldistancia.Name = "labeldistancia";
            labeldistancia.Size = new Size(91, 28);
            labeldistancia.TabIndex = 10;
            labeldistancia.Text = "Distancia";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Margin = new Padding(3, 4, 3, 4);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(457, 673);
            splitter1.TabIndex = 12;
            splitter1.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnReturn, btnMarcações, toolStripSeparator1, btnClear, toolStripSeparator2, btnRota, toolStripSeparator, toolStripButton1 });
            toolStrip1.Location = new Point(457, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(605, 27);
            toolStrip1.TabIndex = 27;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnReturn
            // 
            btnReturn.BackgroundImage = Properties.Resources._688879_arrows_512x512;
            btnReturn.BackgroundImageLayout = ImageLayout.Stretch;
            btnReturn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnReturn.ImageTransparentColor = Color.Magenta;
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(29, 24);
            btnReturn.Text = "Retornar";
            btnReturn.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnMarcações
            // 
            btnMarcações.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnMarcações.ImageTransparentColor = Color.Magenta;
            btnMarcações.Name = "btnMarcações";
            btnMarcações.Size = new Size(147, 24);
            btnMarcações.Text = "Remover Marcações";
            btnMarcações.Click += btnAtualizar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnClear
            // 
            btnClear.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnClear.ImageTransparentColor = Color.Magenta;
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 24);
            btnClear.Text = "Limpar Rota";
            btnClear.Click += btnCad_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // btnRota
            // 
            btnRota.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnRota.ImageTransparentColor = Color.Magenta;
            btnRota.Name = "btnRota";
            btnRota.Size = new Size(44, 24);
            btnRota.Text = "Rota";
            btnRota.Click += btnApaga_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 27);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(123, 24);
            toolStripButton1.Text = "Escolher Destino";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(555, 349);
            txtEndereco.Margin = new Padding(3, 4, 3, 4);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(114, 27);
            txtEndereco.TabIndex = 28;
            // 
            // MapaTeste
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(txtEndereco);
            Controls.Add(toolStrip1);
            Controls.Add(labeldistancia);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtLong);
            Controls.Add(txtLat);
            Controls.Add(label1);
            Controls.Add(MapaBr);
            Controls.Add(splitter1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MapaTeste";
            Text = "MapaTeste";
            Load += MapaTeste_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl MapaBr;
        private Label label1;
        private TextBox txtLat;
        private TextBox txtLong;
        private Label label2;
        private Button button1;
        private Label labeldistancia;
        private Splitter splitter1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnReturn;
        private ToolStripButton btnMarcações;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnClear;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnRota;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton toolStripButton1;
        private TextBox txtEndereco;
    }
}