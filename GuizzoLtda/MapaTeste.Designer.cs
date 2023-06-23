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
            lblLat = new Label();
            txtLat = new TextBox();
            txtLong = new TextBox();
            lblLon = new Label();
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
            label3 = new Label();
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
            MapaBr.Size = new Size(400, 450);
            MapaBr.TabIndex = 1;
            MapaBr.Zoom = 0D;
            MapaBr.Load += gMapControl1_Load;
            // 
            // lblLat
            // 
            lblLat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLat.AutoSize = true;
            lblLat.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLat.Location = new Point(504, 57);
            lblLat.Name = "lblLat";
            lblLat.Size = new Size(88, 30);
            lblLat.TabIndex = 2;
            lblLat.Text = "Latitude";
            lblLat.Visible = false;
            // 
            // txtLat
            // 
            txtLat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtLat.Location = new Point(504, 93);
            txtLat.Name = "txtLat";
            txtLat.Size = new Size(175, 23);
            txtLat.TabIndex = 3;
            txtLat.Visible = false;
            // 
            // txtLong
            // 
            txtLong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtLong.Location = new Point(504, 167);
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
            lblLon.Location = new Point(504, 134);
            lblLon.Name = "lblLon";
            lblLon.Size = new Size(106, 30);
            lblLon.TabIndex = 5;
            lblLon.Text = "Longitude";
            lblLon.Visible = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(478, 356);
            button1.Name = "button1";
            button1.Size = new Size(253, 65);
            button1.TabIndex = 6;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labeldistancia
            // 
            labeldistancia.AutoSize = true;
            labeldistancia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labeldistancia.Location = new Point(555, 202);
            labeldistancia.Name = "labeldistancia";
            labeldistancia.Size = new Size(73, 21);
            labeldistancia.TabIndex = 10;
            labeldistancia.Text = "Distancia";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(400, 450);
            splitter1.TabIndex = 12;
            splitter1.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnReturn, btnMarcações, toolStripSeparator1, btnClear, toolStripSeparator2, btnRota, toolStripSeparator, toolStripButton1 });
            toolStrip1.Location = new Point(400, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(400, 25);
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
            btnReturn.Size = new Size(23, 22);
            btnReturn.Text = "Retornar";
            btnReturn.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnMarcações
            // 
            btnMarcações.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnMarcações.ImageTransparentColor = Color.Magenta;
            btnMarcações.Name = "btnMarcações";
            btnMarcações.Size = new Size(118, 22);
            btnMarcações.Text = "Remover Marcações";
            btnMarcações.Click += btnAtualizar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnClear
            // 
            btnClear.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnClear.ImageTransparentColor = Color.Magenta;
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 22);
            btnClear.Text = "Limpar Rota";
            btnClear.Click += btnCad_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // btnRota
            // 
            btnRota.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnRota.ImageTransparentColor = Color.Magenta;
            btnRota.Name = "btnRota";
            btnRota.Size = new Size(35, 22);
            btnRota.Text = "Rota";
            btnRota.Click += btnApaga_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 25);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(98, 22);
            toolStripButton1.Text = "Escolher Destino";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(504, 176);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(210, 23);
            txtEndereco.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(469, 158);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 29;
            label3.Text = "Insira o Endereço";
            // 
            // MapaTeste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtEndereco);
            Controls.Add(toolStrip1);
            Controls.Add(labeldistancia);
            Controls.Add(button1);
            Controls.Add(lblLon);
            Controls.Add(txtLong);
            Controls.Add(txtLat);
            Controls.Add(lblLat);
            Controls.Add(MapaBr);
            Controls.Add(splitter1);
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
        private Label lblLat;
        private TextBox txtLat;
        private TextBox txtLong;
        private Label lblLon;
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
        private Label label3;
    }
}