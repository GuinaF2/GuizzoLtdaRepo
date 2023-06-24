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
            this.MapaBr = new GMap.NET.WindowsForms.GMapControl();
            this.lblLat = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.lblLon = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labeldistancia = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnReturn = new System.Windows.Forms.ToolStripButton();
            this.btnMarcações = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRota = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MapaBr
            // 
            this.MapaBr.Bearing = 0F;
            this.MapaBr.CanDragMap = true;
            this.MapaBr.EmptyTileColor = System.Drawing.Color.Navy;
            this.MapaBr.GrayScaleMode = false;
            this.MapaBr.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MapaBr.LevelsKeepInMemmory = 5;
            this.MapaBr.Location = new System.Drawing.Point(0, 0);
            this.MapaBr.MarkersEnabled = true;
            this.MapaBr.MaxZoom = 50;
            this.MapaBr.MinZoom = 5;
            this.MapaBr.MouseWheelZoomEnabled = true;
            this.MapaBr.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MapaBr.Name = "MapaBr";
            this.MapaBr.NegativeMode = false;
            this.MapaBr.PolygonsEnabled = true;
            this.MapaBr.RetryLoadTile = 0;
            this.MapaBr.RoutesEnabled = true;
            this.MapaBr.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MapaBr.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MapaBr.ShowTileGridLines = false;
            this.MapaBr.Size = new System.Drawing.Size(400, 450);
            this.MapaBr.TabIndex = 1;
            this.MapaBr.Zoom = 0D;
            // 
            // lblLat
            // 
            this.lblLat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLat.AutoSize = true;
            this.lblLat.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLat.Location = new System.Drawing.Point(600, 259);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(88, 30);
            this.lblLat.TabIndex = 2;
            this.lblLat.Text = "Latitude";
            this.lblLat.Visible = false;
            // 
            // txtLat
            // 
            this.txtLat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLat.Location = new System.Drawing.Point(600, 295);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(175, 23);
            this.txtLat.TabIndex = 3;
            this.txtLat.Visible = false;
            // 
            // txtLong
            // 
            this.txtLong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLong.Location = new System.Drawing.Point(600, 242);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(173, 23);
            this.txtLong.TabIndex = 4;
            this.txtLong.Visible = false;
            // 
            // lblLon
            // 
            this.lblLon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLon.AutoSize = true;
            this.lblLon.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLon.Location = new System.Drawing.Point(600, 209);
            this.lblLon.Name = "lblLon";
            this.lblLon.Size = new System.Drawing.Size(106, 30);
            this.lblLon.TabIndex = 5;
            this.lblLon.Text = "Longitude";
            this.lblLon.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(478, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 65);
            this.button1.TabIndex = 6;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labeldistancia
            // 
            this.labeldistancia.AutoSize = true;
            this.labeldistancia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeldistancia.Location = new System.Drawing.Point(506, 202);
            this.labeldistancia.Name = "labeldistancia";
            this.labeldistancia.Size = new System.Drawing.Size(73, 21);
            this.labeldistancia.TabIndex = 10;
            this.labeldistancia.Text = "Distancia";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(400, 450);
            this.splitter1.TabIndex = 12;
            this.splitter1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReturn,
            this.btnMarcações,
            this.toolStripSeparator1,
            this.btnClear,
            this.toolStripSeparator2,
            this.btnRota,
            this.toolStripSeparator,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(400, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(400, 25);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundImage = global::GuizzoLtda.Properties.Resources._688879_arrows_512x512;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(23, 22);
            this.btnReturn.Text = "Retornar";
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // btnMarcações
            // 
            this.btnMarcações.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMarcações.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMarcações.Name = "btnMarcações";
            this.btnMarcações.Size = new System.Drawing.Size(118, 22);
            this.btnMarcações.Text = "Remover Marcações";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnClear
            // 
            this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 22);
            this.btnClear.Text = "Limpar Rota";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRota
            // 
            this.btnRota.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRota.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRota.Name = "btnRota";
            this.btnRota.Size = new System.Drawing.Size(35, 22);
            this.btnRota.Text = "Rota";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(98, 22);
            this.toolStripButton1.Text = "Escolher Destino";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(506, 163);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(210, 23);
            this.txtEndereco.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(506, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 32);
            this.label3.TabIndex = 29;
            this.label3.Text = "Insira a Origem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(506, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 30;
            this.label1.Text = "Insira o Destino";
            this.label1.Visible = false;
            // 
            // MapaTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labeldistancia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblLon);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.lblLat);
            this.Controls.Add(this.MapaBr);
            this.Controls.Add(this.splitter1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MapaTeste";
            this.Text = "MapaTeste";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label label1;
    }
}