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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapaTeste));
            MapaBr = new GMap.NET.WindowsForms.GMapControl();
            lblLat = new Label();
            txtLat = new TextBox();
            txtLong = new TextBox();
            lblLon = new Label();
            btnConfirmar = new Button();
            labeldistancia = new Label();
            splitter1 = new Splitter();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnMarcações = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnClear = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnRota = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            btnMarcaPonto = new ToolStripButton();
            txtEndereco = new TextBox();
            label3 = new Label();
            label1 = new Label();
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
            MapaBr.Size = new Size(371, 450);
            MapaBr.TabIndex = 1;
            MapaBr.Zoom = 0D;
            MapaBr.Load += MapaBr_Load;
            // 
            // lblLat
            // 
            lblLat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLat.AutoSize = true;
            lblLat.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLat.Location = new Point(600, 259);
            lblLat.Name = "lblLat";
            lblLat.Size = new Size(88, 30);
            lblLat.TabIndex = 2;
            lblLat.Text = "Latitude";
            lblLat.Visible = false;
            // 
            // txtLat
            // 
            txtLat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtLat.Location = new Point(600, 295);
            txtLat.Name = "txtLat";
            txtLat.Size = new Size(175, 23);
            txtLat.TabIndex = 3;
            txtLat.Visible = false;
            // 
            // txtLong
            // 
            txtLong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtLong.Location = new Point(600, 242);
            txtLong.Name = "txtLong";
            txtLong.Size = new Size(173, 23);
            txtLong.TabIndex = 4;
            txtLong.Visible = false;
            // 
            // lblLon
            // 
            lblLon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLon.AutoSize = true;
            lblLon.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLon.Location = new Point(600, 209);
            lblLon.Name = "lblLon";
            lblLon.Size = new Size(106, 30);
            lblLon.TabIndex = 5;
            lblLon.Text = "Longitude";
            lblLon.Visible = false;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConfirmar.FlatStyle = FlatStyle.Popup;
            btnConfirmar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmar.ForeColor = Color.Goldenrod;
            btnConfirmar.Location = new Point(478, 356);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(253, 65);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += button1_Click_1;
            // 
            // labeldistancia
            // 
            labeldistancia.AutoSize = true;
            labeldistancia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labeldistancia.ForeColor = Color.Goldenrod;
            labeldistancia.Location = new Point(506, 189);
            labeldistancia.Name = "labeldistancia";
            labeldistancia.Size = new Size(73, 21);
            labeldistancia.TabIndex = 10;
            labeldistancia.Text = "Distancia";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(371, 450);
            splitter1.TabIndex = 12;
            splitter1.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(64, 0, 0);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator3, btnMarcações, toolStripSeparator1, btnClear, toolStripSeparator2, btnRota, toolStripSeparator, btnMarcaPonto });
            toolStrip1.Location = new Point(371, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(429, 25);
            toolStrip1.TabIndex = 27;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.BackColor = Color.Goldenrod;
            toolStripButton1.BackgroundImage = Properties.Resources._688879_arrows_512x512;
            toolStripButton1.BackgroundImageLayout = ImageLayout.Stretch;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources._688879_arrows_512x512;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // btnMarcações
            // 
            btnMarcações.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnMarcações.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMarcações.ForeColor = Color.Goldenrod;
            btnMarcações.ImageTransparentColor = Color.Magenta;
            btnMarcações.Name = "btnMarcações";
            btnMarcações.Size = new Size(132, 22);
            btnMarcações.Text = "Remover Marcações";
            btnMarcações.Click += btnMarcações_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnClear
            // 
            btnClear.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = Color.Goldenrod;
            btnClear.ImageTransparentColor = Color.Magenta;
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(83, 22);
            btnClear.Text = "Limpar Rota";
            btnClear.Click += btnClear_Click_1;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // btnRota
            // 
            btnRota.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnRota.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRota.ForeColor = Color.Goldenrod;
            btnRota.ImageTransparentColor = Color.Magenta;
            btnRota.Name = "btnRota";
            btnRota.Size = new Size(39, 22);
            btnRota.Text = "Rota";
            btnRota.Click += btnRota_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 25);
            // 
            // btnMarcaPonto
            // 
            btnMarcaPonto.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnMarcaPonto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMarcaPonto.ForeColor = Color.Goldenrod;
            btnMarcaPonto.ImageTransparentColor = Color.Magenta;
            btnMarcaPonto.Name = "btnMarcaPonto";
            btnMarcaPonto.Size = new Size(92, 22);
            btnMarcaPonto.Text = "Marcar Ponto";
            btnMarcaPonto.Visible = false;
            btnMarcaPonto.Click += toolStripButton1_Click_1;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(506, 163);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(210, 23);
            txtEndereco.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Goldenrod;
            label3.Location = new Point(506, 110);
            label3.Name = "label3";
            label3.Size = new Size(176, 32);
            label3.TabIndex = 29;
            label3.Text = "Insira a Origem";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(506, 110);
            label1.Name = "label1";
            label1.Size = new Size(180, 32);
            label1.TabIndex = 30;
            label1.Text = "Insira o Destino";
            label1.Visible = false;
            // 
            // MapaTeste
            // 
            AcceptButton = btnConfirmar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(173, 11, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txtEndereco);
            Controls.Add(toolStrip1);
            Controls.Add(labeldistancia);
            Controls.Add(btnConfirmar);
            Controls.Add(lblLon);
            Controls.Add(txtLong);
            Controls.Add(txtLat);
            Controls.Add(lblLat);
            Controls.Add(MapaBr);
            Controls.Add(splitter1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MapaTeste";
            Text = "MapaTeste";
            Load += MapaTeste_Load_1;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl MapaBr;
        private Label lblLat;
        private TextBox txtLat;
        private TextBox txtLong;
        private Label lblLon;
        private Button btnConfirmar;
        private Label labeldistancia;
        private Splitter splitter1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnMarcações;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnClear;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnRota;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton btnMarcaPonto;
        private TextBox txtEndereco;
        private Label label3;
        private Label label1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator3;
    }
}