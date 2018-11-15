<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ClustererSample/Form1.cs) (VB: [Form1.vb](./VB/ClustererSample/Form1.vb))
* [Program.cs](./CS/ClustererSample/Program.cs)
<!-- default file list end -->
# How to aggregate vector items using a clusterer


This example demonstrates how to apply vector item clustering to the Map Control.


<h3>Description</h3>

<p>To do this, assign an object of a class implementing the&nbsp;<strong>IClusterer</strong>&nbsp;interface to the&nbsp;<strong>IMapDataAdapter.Clusterer</strong>&nbsp;property.<br />Then, optionally, configure the clusterer. For example, all predefined clusterers allow you to group items before clustering and customize the appearance of cluster representatives.<br />To group the items, assign&nbsp;<strong>AttributeGroupProvider</strong>&nbsp;to the&nbsp;<strong>MapClustererBase.GroupProvider</strong>&nbsp;property. Then set the&nbsp;<strong>AttributeName&nbsp;</strong>property to the required value.<br />To customize the appearance of the cluster representatives, design a class implementing the&nbsp;<strong>IClusterItemFactory&nbsp;</strong>interface. Then call&nbsp;the <strong>MapClustererBase.SetClusterItemFactory&nbsp;</strong>method with an object of the class to assign the required factory object to a clusterer.</p>

<br/>


