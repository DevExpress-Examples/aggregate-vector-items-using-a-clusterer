using DevExpress.XtraMap;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ClustererSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        #region #Clusterer
        VectorItemsLayer VectorLayer { get { return (VectorItemsLayer)map.Layers["VectorLayer"]; } }
        ListSourceDataAdapter DataAdapter { get { return (ListSourceDataAdapter)VectorLayer.Data; } }

        private void Form1_Load(object sender, EventArgs e) {
            DataAdapter.DataSource = LoadData();
            DistanceBasedClusterer clusterer = new DistanceBasedClusterer {
                GroupProvider = new AttributeGroupProvider {
                    AttributeName = "LocationName"
                }
            };
            clusterer.SetClusterItemFactory(new CustomClusterItemFactory());
            DataAdapter.Clusterer = clusterer;

        }
        #endregion #Clusterer

        List<Tree> LoadData() {
            List<Tree> trees = new List<Tree>();
            XDocument doc = XDocument.Load("Data\\TreesCl.xml");
            foreach(XElement xTree in doc.Element("RowSet").Elements("Row")) {
                trees.Add(new Tree {
                    Latitude = Convert.ToDouble(xTree.Element("lat").Value),
                    Longitude = Convert.ToDouble(xTree.Element("lon").Value),
                    LocationName = xTree.Element("location").Value
                });
            }
            return trees;
        }
    }

    #region #Factory
    class CustomClusterItemFactory : IClusterItemFactory {
        public MapItem CreateClusterItem(IList<MapItem> objects) {
            MapDot dot = new MapDot();
            dot.ClusteredItems = objects;
            dot.TitleOptions.Pattern = objects.Count.ToString();
            return dot;
        }
    }
    #endregion #Factory

    class Tree {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string LocationName { get; set; }
    }
}
