using DevExpress.XtraMap;
using System;
using System.Collections.Generic;
using System.Globalization;
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
                ItemMaxSize = 60,
                ItemMinSize = 14,
                GroupProvider = new AttributeGroupProvider {
                    AttributeName = "LocationName"
                }
            };

            clusterer.SetClusterItemFactory(new CustomClusterItemFactory());
            DataAdapter.Clusterer = clusterer;

            DataAdapter.PropertyMappings.Add(new MapDotSizeMapping { DefaultValue = 14 });

            MouseHoverInteractiveClusterMode interactiveMode = new MouseHoverInteractiveClusterMode();
            interactiveMode.ExpandedClusterLayout = new ExpandedClusterAdaptiveLayout();
            map.InteractiveClusterMode = interactiveMode;
        }
        #endregion #Clusterer

        List<Tree> LoadData() {
            List<Tree> trees = new List<Tree>();
            XDocument doc = XDocument.Load("Data\\TreesCl.xml");
            foreach (XElement xTree in doc.Element("RowSet").Elements("Row")) {
                trees.Add(new Tree {
                    Latitude = Convert.ToDouble(xTree.Element("lat").Value, CultureInfo.InvariantCulture),
                    Longitude = Convert.ToDouble(xTree.Element("lon").Value, CultureInfo.InvariantCulture),
                    LocationName = xTree.Element("location").Value.ToString(CultureInfo.InvariantCulture)
                });
            }
            return trees;
        }
    }

    #region #Factory
    class CustomClusterItemFactory : IClusterItemFactory {
        public MapItem CreateClusterItem(IList<MapItem> objects) {
            return new MapDot();
        }

        public void CustomizeCluster(MapItem cluster) {
            ((MapDot)cluster).TitleOptions.Pattern = cluster.ClusteredItems.Count.ToString();
        }
    }
    #endregion #Factory

    class Tree {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string LocationName { get; set; }
    }
}
