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
            DevExpress.XtraMap.ImageTilesLayer imageTilesLayer1 = new DevExpress.XtraMap.ImageTilesLayer();
            DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            DevExpress.XtraMap.VectorItemsLayer vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            DevExpress.XtraMap.KeyColorColorizer keyColorColorizer1 = new DevExpress.XtraMap.KeyColorColorizer();
            DevExpress.XtraMap.AttributeItemKeyProvider attributeItemKeyProvider1 = new DevExpress.XtraMap.AttributeItemKeyProvider();
            DevExpress.XtraMap.ListSourceDataAdapter listSourceDataAdapter1 = new DevExpress.XtraMap.ListSourceDataAdapter();
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping1 = new DevExpress.XtraMap.MapItemAttributeMapping();
            DevExpress.XtraMap.ColorListLegend colorListLegend1 = new DevExpress.XtraMap.ColorListLegend();
            DevExpress.XtraMap.ColorScaleLegend colorScaleLegend1 = new DevExpress.XtraMap.ColorScaleLegend();
            this.map = new DevExpress.XtraMap.MapControl();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.CenterPoint = new DevExpress.XtraMap.GeoPoint(-37.551D, 143.83D);
            this.map.Dock = System.Windows.Forms.DockStyle.Fill;
            bingMapDataProvider1.BingKey = "Your Bing Key Here";
            imageTilesLayer1.DataProvider = bingMapDataProvider1;
            attributeItemKeyProvider1.AttributeName = "LocationName";
            keyColorColorizer1.ItemKeyProvider = attributeItemKeyProvider1;
            keyColorColorizer1.PredefinedColorSchema = DevExpress.XtraMap.PredefinedColorSchema.Palette;
            vectorItemsLayer1.Colorizer = keyColorColorizer1;
            mapItemAttributeMapping1.Member = "LocationName";
            mapItemAttributeMapping1.Name = "LocationName";
            mapItemAttributeMapping1.ValueType = DevExpress.XtraMap.FieldValueType.String;
            listSourceDataAdapter1.AttributeMappings.Add(mapItemAttributeMapping1);
            listSourceDataAdapter1.DefaultMapItemType = DevExpress.XtraMap.MapItemType.Dot;
            listSourceDataAdapter1.Mappings.Latitude = "Latitude";
            listSourceDataAdapter1.Mappings.Longitude = "Longitude";
            vectorItemsLayer1.Data = listSourceDataAdapter1;
            vectorItemsLayer1.Name = "VectorLayer";
            this.map.Layers.Add(imageTilesLayer1);
            this.map.Layers.Add(vectorItemsLayer1);
            colorListLegend1.Header = "Tree Location";
            colorListLegend1.ItemStyle.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            colorListLegend1.Layer = vectorItemsLayer1;
            colorListLegend1.Visibility = DevExpress.XtraMap.VisibilityMode.Hidden;
            colorScaleLegend1.Alignment = DevExpress.XtraMap.LegendAlignment.TopRight;
            colorScaleLegend1.Header = "Tree Count";
            colorScaleLegend1.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            colorScaleLegend1.ItemStyle.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            colorScaleLegend1.Layer = vectorItemsLayer1;
            colorScaleLegend1.Visibility = DevExpress.XtraMap.VisibilityMode.Hidden;
            this.map.Legends.Add(colorListLegend1);
            this.map.Legends.Add(colorScaleLegend1);
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(640, 360);
            this.map.TabIndex = 0;
            this.map.ZoomLevel = 12D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.map);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl map;
    }
}

