<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128585263/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T477893)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Diagram - Use the DiagramDataBindingBehavior to Generate a Diagram from a Collection

This example uses the [DiagramDataBindingBehavior](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehavior) to generate a diagram from a data source or collection.

![image](https://user-images.githubusercontent.com/65009440/227240921-0829fac7-6180-487b-9971-e9585ee6469f.png)

1. Add the [DiagramDataBindingBehavior](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehavior) to the [DiagramControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramControl).

2. Specify the following properties to map the behavior to data:

   * The [ItemsSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehaviorBase.ItemsSource) property specifies a collection of diagram items.
   * The [KeyMember](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramDataBindingControllerBase.KeyMember) and [ConnectorsSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehavior.ConnectorsSource) properties allow you to display relationships between diagram items.
   * The [ConnectorFromMember](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehavior.ConnectorFromMember) and [ConnectorToMember](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehavior.ConnectorToMember) properties specify data fields that contain a connector's begin and end items.

3. Use the [Item Template Designer](https://docs.devexpress.com/WPF/117615/controls-and-libraries/diagram-control/data-binding/item-template-designer) to create "templates" for diagram items and connectors.

   This designer creates a [TemplateDiagram](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehaviorBase.TemplateDiagram) object that contains generated code with diagram shapes and connectors.
   
4. Handle the [GenerateItem](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehaviorBase.GenerateItem) and [GenerateConnector](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehaviorBase.GenerateConnector) events to display different items based on a condition.

   In these event handlers, the [TemplateName](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramItem.TemplateName) property value allows you to identify generated "templates".

## Files to Review

* [ClassData.cs](./CS/DiagramDataBindingBehavior/Data/ClassData.cs) (VB: [ClassData.vb](./VB/DiagramDataBindingBehavior/Data/ClassData.vb))
* [ClassStructureGenerator.cs](./CS/DiagramDataBindingBehavior/Data/ClassStructureGenerator.cs) (VB: [ClassStructureGenerator.vb](./VB/DiagramDataBindingBehavior/Data/ClassStructureGenerator.vb))
* [MainWindow.xaml](./CS/DiagramDataBindingBehavior/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DiagramDataBindingBehavior/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DiagramDataBindingBehavior/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DiagramDataBindingBehavior/MainWindow.xaml.vb))
* [ViewModel.cs](./CS/DiagramDataBindingBehavior/ViewModel/ViewModel.cs) (VB: [ViewModel.vb](./VB/DiagramDataBindingBehavior/ViewModel/ViewModel.vb))

## Documentation

* [Generate Diagrams from a Data Source](https://docs.devexpress.com/WPF/118578/controls-and-libraries/diagram-control/data-binding/generating-diagrams-from-a-data-source)
* [Item Template Designer](https://docs.devexpress.com/WPF/117615/controls-and-libraries/diagram-control/data-binding/item-template-designer)

## More Examples

* [WPF Diagram - Use the DiagramOrgChartBehavior to Generate a Diagram from a Collection](https://github.com/DevExpress-Examples/how-to-generate-a-diagram-from-a-collection-using-diagramorgchartbehavior-t476835)
