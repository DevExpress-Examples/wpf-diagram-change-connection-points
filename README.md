<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/583004091/22.2.3%2B)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# DiagramControl for WPF - How to change a shape's connection points at runtime

This example shows how to use the [ConnectionPoints](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramItem.ConnectionPoints) property to change the number of a shape's connection points at runtime.

The `ConnectionPoints` collection does not have public members that allow adding or removing items from it. You need to re-initialize it instead:
```cs
Point[] points = new Point[...];
shape.ConnectionPoints = new DevExpress.Diagram.Core.DiagramPointCollection(points);
```

## Files to Review

- [MainWindow.xaml](/CS/MainWindow.xaml) (VB: [MainWindow.xaml](/VB/MainWindow.xaml))
- [MainWindow.xaml.cs](/CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](/VB/MainWindow.xaml.vb))

## Documentation

[Connectors](https://docs.devexpress.com/WPF/116648/controls-and-libraries/diagram-control/diagram-items/connectors)

## More Examples

[How to create custom shapes with custom connection points for DiagramDesignerControl](https://github.com/DevExpress-Examples/how-to-create-custom-shapes-with-custom-connection-points-for-diagramdesignercontrol-t320892)
