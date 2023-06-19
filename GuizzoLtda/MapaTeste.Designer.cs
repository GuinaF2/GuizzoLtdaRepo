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
            splitter1 = new Splitter();
            MapaBr = new GMap.NET.WindowsForms.GMapControl();
            label1 = new Label();
            txtLat = new TextBox();
            txtLong = new TextBox();
            label2 = new Label();
            button1 = new Button();
            btnPara = new Button();
            btnClear = new Button();
            btnGetInfo = new Button();
            labeldistancia = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(409, 450);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            splitter1.SplitterMoved += splitter1_SplitterMoved;
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
            MapaBr.Size = new Size(409, 450);
            MapaBr.TabIndex = 1;
            MapaBr.Zoom = 0D;
            MapaBr.Load += gMapControl1_Load;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(447, 17);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Latitute";
            // 
            // txtLat
            // 
            txtLat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtLat.Location = new Point(452, 91);
            txtLat.Name = "txtLat";
            txtLat.Size = new Size(99, 23);
            txtLat.TabIndex = 3;
            // 
            // txtLong
            // 
            txtLong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtLong.Location = new Point(451, 169);
            txtLong.Name = "txtLong";
            txtLong.Size = new Size(100, 23);
            txtLong.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(449, 139);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 5;
            label2.Text = "Longitude";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(547, 319);
            button1.Name = "button1";
            button1.Size = new Size(190, 49);
            button1.TabIndex = 6;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnPara
            // 
            btnPara.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPara.Location = new Point(621, 80);
            btnPara.Name = "btnPara";
            btnPara.Size = new Size(152, 34);
            btnPara.TabIndex = 7;
            btnPara.Text = "Adicionar Parada";
            btnPara.UseVisualStyleBackColor = true;
            btnPara.Click += btnPara_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.Location = new Point(621, 17);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(152, 38);
            btnClear.TabIndex = 8;
            btnClear.Text = "LimparLista";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnGetInfo
            // 
            btnGetInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetInfo.Location = new Point(619, 139);
            btnGetInfo.Name = "btnGetInfo";
            btnGetInfo.Size = new Size(155, 43);
            btnGetInfo.TabIndex = 9;
            btnGetInfo.Text = "Informações da Rota";
            btnGetInfo.UseVisualStyleBackColor = true;
            btnGetInfo.Click += btnGetInfo_Click;
            // 
            // labeldistancia
            // 
            labeldistancia.AutoSize = true;
            labeldistancia.Location = new Point(449, 216);
            labeldistancia.Name = "labeldistancia";
            labeldistancia.Size = new Size(55, 15);
            labeldistancia.TabIndex = 10;
            labeldistancia.Text = "Distancia";
            // 
            // button2
            // 
            button2.Location = new Point(614, 236);
            button2.Name = "button2";
            button2.Size = new Size(123, 29);
            button2.TabIndex = 11;
            button2.Text = "Remover Marcações";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MapaTeste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(labeldistancia);
            Controls.Add(btnGetInfo);
            Controls.Add(btnClear);
            Controls.Add(btnPara);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtLong);
            Controls.Add(txtLat);
            Controls.Add(label1);
            Controls.Add(MapaBr);
            Controls.Add(splitter1);
            Name = "MapaTeste";
            Text = "MapaTeste";
            Load += MapaTeste_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl MapaBr;
        private Label label1;
        private TextBox txtLat;
        private TextBox txtLong;
        private Label label2;
        private Button button1;
        private Button btnPara;
        private Button btnClear;
        private Button btnGetInfo;
        private Label labeldistancia;
        private Button button2;
    }
}