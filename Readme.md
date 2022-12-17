<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128585263/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T477893)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [ClassData.cs](./CS/DiagramDataBindingBehavior/Data/ClassData.cs) (VB: [ClassData.vb](./VB/DiagramDataBindingBehavior/Data/ClassData.vb))
* [ClassStructureGenerator.cs](./CS/DiagramDataBindingBehavior/Data/ClassStructureGenerator.cs) (VB: [ClassStructureGenerator.vb](./VB/DiagramDataBindingBehavior/Data/ClassStructureGenerator.vb))
* [MainWindow.xaml](./CS/DiagramDataBindingBehavior/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DiagramDataBindingBehavior/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DiagramDataBindingBehavior/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DiagramDataBindingBehavior/MainWindow.xaml.vb))
* [ViewModel.cs](./CS/DiagramDataBindingBehavior/ViewModel/ViewModel.cs) (VB: [ViewModel.vb](./VB/DiagramDataBindingBehavior/ViewModel/ViewModel.vb))
<!-- default file list end -->
# How to generate a diagram from a collection using DiagramDataBindingBehavior


<p>This example demonstrates how to generate a diagram from a certain source/collection using <a href="https://documentation.devexpress.com/WPF/clsDevExpressXpfDiagramDiagramDataBindingBehaviortopic.aspx">DiagramDataBindingBehavior</a>. To provide <a href="https://documentation.devexpress.com/WPF/clsDevExpressXpfDiagramDiagramDataBindingBehaviortopic.aspx">DiagramDataBindingBehavior</a> with the required source, use the <a href="https://documentation.devexpress.com/WPF/DevExpressXpfDiagramDiagramDataBindingBehaviorBase_ItemsSourcetopic.aspx">ItemsSource</a> property. To build and display relationships between diagram shapes, use the <a href="https://documentation.devexpress.com/WindowsForms/DevExpressXtraDiagramDiagramDataBindingControllerBase_KeyMembertopic.aspx">KeyMember</a> property and the <a href="https://documentation.devexpress.com/WPF/DevExpressXpfDiagramDiagramDataBindingBehavior_ConnectorsSourcetopic.aspx">ConnectorsSource</a> collection. The <a href="https://documentation.devexpress.com/WPF/DevExpressXpfDiagramDiagramDataBindingBehavior_ConnectorFromMembertopic.aspx">ConnectorFromMember</a> and <a href="https://documentation.devexpress.com/WPF/DevExpressXpfDiagramDiagramDataBindingBehavior_ConnectorToMembertopic.aspx">ConnectorToMember</a> properties specify data fields that identify items to use as a connector's begin and end items. The <a href="https://documentation.devexpress.com/WPF/DevExpressXpfDiagramDiagramDataBindingBehaviorBase_TemplateDiagramtopic.aspx">TemplateDiagram</a> property contains DiagramItems used to generate and show shapes and connectors according to the bound collection. Each "template" item has the <a href="https://documentation.devexpress.com/WPF/DevExpressXpfDiagramDiagramItem_TemplateNametopic.aspx">TemplateName</a> set to a certain unique value. In the <a href="https://documentation.devexpress.com/WPF/DevExpressXpfDiagramDiagramDataBindingBehaviorBase_GenerateConnectortopic.aspx">GenerateConnector</a> and <a href="https://documentation.devexpress.com/WPF/DevExpressXpfDiagramDiagramDataBindingBehaviorBase_GenerateItemtopic.aspx">GenerateItem</a> event handlers, this property value is used to create a required shape/connector based on a certain condition.<br>See also: <a href="https://documentation.devexpress.com/WPF/CustomDocument117585.aspx">Data Binding Functionality</a>.</p>

<br/>


