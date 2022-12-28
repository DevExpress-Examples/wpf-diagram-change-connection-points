<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/583004091/22.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1136799)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# DiagramControl for WPF - Change a Shape's Connection Points at Runtime

This example modifies a shape's [ConnectionPoints](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramItem.ConnectionPoints) collection at runtime. To illustrate this behavior, we added a trackbar that changes the number and position of connection points.

![image](https://user-images.githubusercontent.com/65009440/209831314-a581710b-3782-468b-b734-57b96d977205.png)

The `ConnectionPoints` collection does not have public members that allow you to add or remove items. To accomplish this task, create a new point collection and assign it to the [ConnectionPoints](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramItem.ConnectionPoints) property:

```cs
Point[] points = new Point[...];
shape.ConnectionPoints = new DevExpress.Diagram.Core.DiagramPointCollection(points);
```

## Files to Review

- [MainWindow.xaml](/CS/MainWindow.xaml) (VB: [MainWindow.xaml](/VB/MainWindow.xaml))
- [MainWindow.xaml.cs](/CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](/VB/MainWindow.xaml.vb))

## Documentation

- [Connectors](https://docs.devexpress.com/WPF/116648/controls-and-libraries/diagram-control/diagram-items/connectors)
- [DiagramItem.ConnectionPoints](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramItem.ConnectionPoints)

## More Examples

- [How to create custom shapes with custom connection points for DiagramDesignerControl](https://github.com/DevExpress-Examples/how-to-create-custom-shapes-with-custom-connection-points-for-diagramdesignercontrol-t320892)
