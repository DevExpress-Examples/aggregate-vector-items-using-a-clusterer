Imports DevExpress.XtraMap
Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Windows.Forms
Imports System.Xml.Linq

Namespace ClustererSample

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

#Region "#Clusterer"
        Private ReadOnly Property VectorLayer As VectorItemsLayer
            Get
                Return CType(map.Layers("VectorLayer"), VectorItemsLayer)
            End Get
        End Property

        Private ReadOnly Property DataAdapter As ListSourceDataAdapter
            Get
                Return CType(VectorLayer.Data, ListSourceDataAdapter)
            End Get
        End Property

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            DataAdapter.DataSource = LoadData()
            Dim clusterer As DistanceBasedClusterer = New DistanceBasedClusterer With {.ItemMaxSize = 60, .ItemMinSize = 14, .GroupProvider = New AttributeGroupProvider With {.AttributeName = "LocationName"}}
            clusterer.SetClusterItemFactory(New CustomClusterItemFactory())
            DataAdapter.Clusterer = clusterer
            DataAdapter.PropertyMappings.Add(New MapDotSizeMapping With {.DefaultValue = 14})
            Dim interactiveMode As MouseHoverInteractiveClusterMode = New MouseHoverInteractiveClusterMode()
            interactiveMode.ExpandedClusterLayout = New ExpandedClusterAdaptiveLayout()
            map.InteractiveClusterMode = interactiveMode
        End Sub

#End Region  ' #Clusterer
        Private Function LoadData() As List(Of Tree)
            Dim trees As List(Of Tree) = New List(Of Tree)()
            Dim doc As XDocument = XDocument.Load("Data\TreesCl.xml")
            For Each xTree As XElement In doc.Element("RowSet").Elements("Row")
                trees.Add(New Tree With {.Latitude = Convert.ToDouble(xTree.Element("lat").Value, CultureInfo.InvariantCulture), .Longitude = Convert.ToDouble(xTree.Element("lon").Value, CultureInfo.InvariantCulture), .LocationName = xTree.Element("location").Value.ToString(CultureInfo.InvariantCulture)})
            Next

            Return trees
        End Function
    End Class

#Region "#Factory"
    Friend Class CustomClusterItemFactory
        Inherits IClusterItemFactory

        Public Function CreateClusterItem(ByVal objects As IList(Of MapItem)) As MapItem
            Return New MapDot()
        End Function

        Public Sub CustomizeCluster(ByVal cluster As MapItem)
            CType(cluster, MapDot).TitleOptions.Pattern = cluster.ClusteredItems.Count.ToString()
        End Sub
    End Class

#End Region  ' #Factory
    Friend Class Tree

        Public Property Latitude As Double

        Public Property Longitude As Double

        Public Property LocationName As String
    End Class
End Namespace
