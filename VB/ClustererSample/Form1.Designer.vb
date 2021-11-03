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
            Dim keyColorColorizer1 As DevExpress.XtraMap.KeyColorColorizer = New DevExpress.XtraMap.KeyColorColorizer()
            Dim attributeItemKeyProvider1 As DevExpress.XtraMap.AttributeItemKeyProvider = New DevExpress.XtraMap.AttributeItemKeyProvider()
            Dim mapItemAttributeMapping1 As DevExpress.XtraMap.MapItemAttributeMapping = New DevExpress.XtraMap.MapItemAttributeMapping()
            Dim colorListLegend2 As DevExpress.XtraMap.ColorListLegend = New DevExpress.XtraMap.ColorListLegend()
            Dim colorScaleLegend2 As DevExpress.XtraMap.ColorScaleLegend = New DevExpress.XtraMap.ColorScaleLegend()
            Me.vectorItemsLayer1 = New DevExpress.XtraMap.VectorItemsLayer()
            Me.listSourceDataAdapter1 = New DevExpress.XtraMap.ListSourceDataAdapter()
            Me.imageTilesLayer1 = New DevExpress.XtraMap.ImageLayer()
            Me.bingMapDataProvider1 = New DevExpress.XtraMap.BingMapDataProvider()
            Me.map = New DevExpress.XtraMap.MapControl()
            CType((Me.map), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            attributeItemKeyProvider1.AttributeName = "LocationName"
            keyColorColorizer1.ItemKeyProvider = attributeItemKeyProvider1
            keyColorColorizer1.PredefinedColorSchema = DevExpress.XtraMap.PredefinedColorSchema.Palette
            Me.vectorItemsLayer1.Colorizer = keyColorColorizer1
            Me.vectorItemsLayer1.Data = Me.listSourceDataAdapter1
            Me.vectorItemsLayer1.Name = "VectorLayer"
            mapItemAttributeMapping1.Member = "LocationName"
            mapItemAttributeMapping1.Name = "LocationName"
            mapItemAttributeMapping1.ValueType = DevExpress.XtraMap.FieldValueType.[String]
            Me.listSourceDataAdapter1.AttributeMappings.Add(mapItemAttributeMapping1)
            Me.listSourceDataAdapter1.DefaultMapItemType = DevExpress.XtraMap.MapItemType.Dot
            Me.listSourceDataAdapter1.Mappings.Latitude = "Latitude"
            Me.listSourceDataAdapter1.Mappings.Longitude = "Longitude"
            Me.imageTilesLayer1.DataProvider = Me.bingMapDataProvider1
            Me.bingMapDataProvider1.BingKey = "Insert your Bing Key here"
            Me.bingMapDataProvider1.Kind = DevExpress.XtraMap.BingMapKind.RoadGray
            ' 
            ' map
            ' 
            Me.map.CenterPoint = New DevExpress.XtraMap.GeoPoint(-37.551R, 143.83R)
            Me.map.Dock = System.Windows.Forms.DockStyle.Fill
            Me.map.Layers.Add(Me.imageTilesLayer1)
            Me.map.Layers.Add(Me.vectorItemsLayer1)
            colorListLegend2.Header = "Tree Location"
            colorListLegend2.ItemStyle.Font = New System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            colorListLegend2.Layer = Me.vectorItemsLayer1
            colorListLegend2.Visibility = DevExpress.XtraMap.VisibilityMode.Hidden
            colorScaleLegend2.Alignment = DevExpress.XtraMap.LegendAlignment.TopRight
            colorScaleLegend2.Header = "Tree Count"
            colorScaleLegend2.HeaderStyle.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            colorScaleLegend2.ItemStyle.Font = New System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            colorScaleLegend2.Layer = Me.vectorItemsLayer1
            colorScaleLegend2.Visibility = DevExpress.XtraMap.VisibilityMode.Hidden
            Me.map.Legends.Add(colorListLegend2)
            Me.map.Legends.Add(colorScaleLegend2)
            Me.map.Location = New System.Drawing.Point(0, 0)
            Me.map.Margin = New System.Windows.Forms.Padding(4)
            Me.map.Name = "map"
            Me.map.Size = New System.Drawing.Size(853, 443)
            Me.map.TabIndex = 0
            Me.map.ZoomLevel = 12R
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(853, 443)
            Me.Controls.Add(Me.map)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.map), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private map As DevExpress.XtraMap.MapControl

        Private imageTilesLayer1 As DevExpress.XtraMap.ImageLayer

        Private bingMapDataProvider1 As DevExpress.XtraMap.BingMapDataProvider

        Private vectorItemsLayer1 As DevExpress.XtraMap.VectorItemsLayer

        Private listSourceDataAdapter1 As DevExpress.XtraMap.ListSourceDataAdapter
    End Class
End Namespace
