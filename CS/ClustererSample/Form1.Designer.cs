namespace ClustererSample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraMap.KeyColorColorizer keyColorColorizer1 = new DevExpress.XtraMap.KeyColorColorizer();
            DevExpress.XtraMap.AttributeItemKeyProvider attributeItemKeyProvider1 = new DevExpress.XtraMap.AttributeItemKeyProvider();
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping1 = new DevExpress.XtraMap.MapItemAttributeMapping();
            DevExpress.XtraMap.ColorListLegend colorListLegend2 = new DevExpress.XtraMap.ColorListLegend();
            DevExpress.XtraMap.ColorScaleLegend colorScaleLegend2 = new DevExpress.XtraMap.ColorScaleLegend();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            this.listSourceDataAdapter1 = new DevExpress.XtraMap.ListSourceDataAdapter();
            this.imageTilesLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            this.map = new DevExpress.XtraMap.MapControl();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            this.SuspendLayout();
            attributeItemKeyProvider1.AttributeName = "LocationName";
            keyColorColorizer1.ItemKeyProvider = attributeItemKeyProvider1;
            keyColorColorizer1.PredefinedColorSchema = DevExpress.XtraMap.PredefinedColorSchema.Palette;
            this.vectorItemsLayer1.Colorizer = keyColorColorizer1;
            this.vectorItemsLayer1.Data = this.listSourceDataAdapter1;
            this.vectorItemsLayer1.Name = "VectorLayer";
            mapItemAttributeMapping1.Member = "LocationName";
            mapItemAttributeMapping1.Name = "LocationName";
            mapItemAttributeMapping1.ValueType = DevExpress.XtraMap.FieldValueType.String;
            this.listSourceDataAdapter1.AttributeMappings.Add(mapItemAttributeMapping1);
            this.listSourceDataAdapter1.DefaultMapItemType = DevExpress.XtraMap.MapItemType.Dot;
            this.listSourceDataAdapter1.Mappings.Latitude = "Latitude";
            this.listSourceDataAdapter1.Mappings.Longitude = "Longitude";
            this.imageTilesLayer1.DataProvider = this.bingMapDataProvider1;
            this.bingMapDataProvider1.BingKey = "Insert your Bing Key here";
            this.bingMapDataProvider1.Kind = DevExpress.XtraMap.BingMapKind.RoadGray;
            // 
            // map
            // 
            this.map.CenterPoint = new DevExpress.XtraMap.GeoPoint(-37.551D, 143.83D);
            this.map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map.Layers.Add(this.imageTilesLayer1);
            this.map.Layers.Add(this.vectorItemsLayer1);
            colorListLegend2.Header = "Tree Location";
            colorListLegend2.ItemStyle.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            colorListLegend2.Layer = this.vectorItemsLayer1;
            colorListLegend2.Visibility = DevExpress.XtraMap.VisibilityMode.Hidden;
            colorScaleLegend2.Alignment = DevExpress.XtraMap.LegendAlignment.TopRight;
            colorScaleLegend2.Header = "Tree Count";
            colorScaleLegend2.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            colorScaleLegend2.ItemStyle.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            colorScaleLegend2.Layer = this.vectorItemsLayer1;
            colorScaleLegend2.Visibility = DevExpress.XtraMap.VisibilityMode.Hidden;
            this.map.Legends.Add(colorListLegend2);
            this.map.Legends.Add(colorScaleLegend2);
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.Margin = new System.Windows.Forms.Padding(4);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(853, 443);
            this.map.TabIndex = 0;
            this.map.ZoomLevel = 12D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 443);
            this.Controls.Add(this.map);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl map;
        private DevExpress.XtraMap.ImageLayer imageTilesLayer1;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1;
        private DevExpress.XtraMap.VectorItemsLayer vectorItemsLayer1;
        private DevExpress.XtraMap.ListSourceDataAdapter listSourceDataAdapter1;
    }
}

