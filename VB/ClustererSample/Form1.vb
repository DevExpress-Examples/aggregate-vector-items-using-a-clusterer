Imports DevExpress.XtraMap
Imports System
Imports System.Collections.Generic
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
            Dim clusterer As DistanceBasedClusterer = New DistanceBasedClusterer With {.GroupProvider = New AttributeGroupProvider With {.AttributeName = "LocationName"}}
            clusterer.SetClusterItemFactory(New CustomClusterItemFactory())
            DataAdapter.Clusterer = clusterer
        End Sub

#End Region  ' #Clusterer
        Private Function LoadData() As List(Of Tree)
            Dim trees As List(Of Tree) = New List(Of Tree)()
            Dim doc As XDocument = XDocument.Load("Data\TreesCl.xml")
            For Each xTree As XElement In doc.Element("RowSet").Elements("Row")
                trees.Add(New Tree With {.Latitude = Convert.ToDouble(xTree.Element("lat").Value), .Longitude = Convert.ToDouble(xTree.Element("lon").Value), .LocationName = xTree.Element("location").Value})
            Next

            Return trees
        End Function
    End Class

#Region "#Factory"
    Friend Class CustomClusterItemFactory
        Inherits IClusterItemFactory

        Public Function CreateClusterItem(ByVal objects As IList(Of MapItem)) As MapItem
            Dim dot As MapDot = New MapDot()
            dot.ClusteredItems = objects
            dot.TitleOptions.Pattern = objects.Count.ToString()
            Return dot
        End Function
    End Class

#End Region  ' #Factory
    Friend Class Tree

        Public Property Latitude As Double

        Public Property Longitude As Double

        Public Property LocationName As String
    End Class
End Namespace
