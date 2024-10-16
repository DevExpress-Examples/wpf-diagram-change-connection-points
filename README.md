<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/583004091/22.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1136799)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# DiagramControl for WPF - Change a Shape's Connection Points at Runtime

This example modifies a shape's [ConnectionPoints](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramItem.ConnectionPoints) collection at runtime. To illustrate this behavior, we added a trackbar that changes the number and position of connection points.

![image](https://user-images.githubusercontent.com/65009440/209833581-f7e5dc80-c3cd-444a-847b-73794ac05411.png)

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
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-diagram-change-connection-points&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-diagram-change-connection-points&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
