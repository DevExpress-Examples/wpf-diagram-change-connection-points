Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.Core
Imports System
Imports System.Windows

Namespace dxSample

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits ThemedWindow

        Private r As Random = New Random()

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub BarEditItem_EditValueChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim editItem = TryCast(sender, BarEditItem)
            Dim value = Convert.ToInt32(editItem.EditValue)
            Dim points As Point() = New Point(value - 1) {}
            For i As Integer = 0 To value - 1
                points(i) = New Point() With {.X = r.NextDouble(), .Y = If(r.Next(0, 2) = 0, 0, 1)}
            Next

            Me.shape.ConnectionPoints = New DevExpress.Diagram.Core.DiagramPointCollection(points)
        End Sub
    End Class
End Namespace
