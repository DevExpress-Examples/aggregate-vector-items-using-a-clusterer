Namespace ClustererSample

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim imageTilesLayer1 As DevExpress.XtraMap.ImageTilesLayer = New DevExpress.XtraMap.ImageTilesLayer()
            Dim bingMapDataProvider1 As DevExpress.XtraMap.BingMapDataProvider = New DevExpress.XtraMap.BingMapDataProvider()
            Dim vectorItemsLayer1 As DevExpress.XtraMap.VectorItemsLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Dim keyColorColorizer1 As DevExpress.XtraMap.KeyColorColorizer = New DevExpress.XtraMap.KeyColorColorizer()
            Dim attributeItemKeyProvider1 As DevExpress.XtraMap.AttributeItemKeyProvider = New DevExpress.XtraMap.AttributeItemKeyProvider()
            Dim listSourceDataAdapter1 As DevExpress.XtraMap.ListSourceDataAdapter = New DevExpress.XtraMap.ListSourceDataAdapter()
            Dim mapItemAttributeMapping1 As DevExpress.XtraMap.MapItemAttributeMapping = New DevExpress.XtraMap.MapItemAttributeMapping()
            Dim colorListLegend1 As DevExpress.XtraMap.ColorListLegend = New DevExpress.XtraMap.ColorListLegend()
            Dim colorScaleLegend1 As DevExpress.XtraMap.ColorScaleLegend = New DevExpress.XtraMap.ColorScaleLegend()
            Me.map = New DevExpress.XtraMap.MapControl()
            CType((Me.map), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' map
            ' 
            Me.map.CenterPoint = New DevExpress.XtraMap.GeoPoint(-37.551R, 143.83R)
            Me.map.Dock = System.Windows.Forms.DockStyle.Fill
            bingMapDataProvider1.BingKey = "Your Bing Key Here"
            imageTilesLayer1.DataProvider = bingMapDataProvider1
            attributeItemKeyProvider1.AttributeName = "LocationName"
            keyColorColorizer1.ItemKeyProvider = attributeItemKeyProvider1
            keyColorColorizer1.PredefinedColorSchema = DevExpress.XtraMap.PredefinedColorSchema.Palette
            vectorItemsLayer1.Colorizer = keyColorColorizer1
            mapItemAttributeMapping1.Member = "LocationName"
            mapItemAttributeMapping1.Name = "LocationName"
            mapItemAttributeMapping1.ValueType = DevExpress.XtraMap.FieldValueType.[String]
            listSourceDataAdapter1.AttributeMappings.Add(mapItemAttributeMapping1)
            listSourceDataAdapter1.DefaultMapItemType = DevExpress.XtraMap.MapItemType.Dot
            listSourceDataAdapter1.Mappings.Latitude = "Latitude"
            listSourceDataAdapter1.Mappings.Longitude = "Longitude"
            vectorItemsLayer1.Data = listSourceDataAdapter1
            vectorItemsLayer1.Name = "VectorLayer"
            Me.map.Layers.Add(imageTilesLayer1)
            Me.map.Layers.Add(vectorItemsLayer1)
            colorListLegend1.Header = "Tree Location"
            colorListLegend1.ItemStyle.Font = New System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            colorListLegend1.Layer = vectorItemsLayer1
            colorListLegend1.Visibility = DevExpress.XtraMap.VisibilityMode.Hidden
            colorScaleLegend1.Alignment = DevExpress.XtraMap.LegendAlignment.TopRight
            colorScaleLegend1.Header = "Tree Count"
            colorScaleLegend1.HeaderStyle.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            colorScaleLegend1.ItemStyle.Font = New System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            colorScaleLegend1.Layer = vectorItemsLayer1
            colorScaleLegend1.Visibility = DevExpress.XtraMap.VisibilityMode.Hidden
            Me.map.Legends.Add(colorListLegend1)
            Me.map.Legends.Add(colorScaleLegend1)
            Me.map.Location = New System.Drawing.Point(0, 0)
            Me.map.Name = "map"
            Me.map.Size = New System.Drawing.Size(640, 360)
            Me.map.TabIndex = 0
            Me.map.ZoomLevel = 12R
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(640, 360)
            Me.Controls.Add(Me.map)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.map), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private map As DevExpress.XtraMap.MapControl
    End Class
End Namespace
