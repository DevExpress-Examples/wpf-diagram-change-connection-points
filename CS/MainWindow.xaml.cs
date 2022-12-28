using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Core;
using System;
using System.Linq;
using System.Windows;

namespace dxSample {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow {
        Random r = new Random();

        public MainWindow() {
            InitializeComponent();
        }

        private void BarEditItem_EditValueChanged(object sender, RoutedEventArgs e) {
            var editItem = sender as BarEditItem;
            var value = Convert.ToInt32(editItem.EditValue);
            Point[] points = new Point[value];

            for (int i = 0; i < value; i++) {
                points[i] = new Point() { X = r.NextDouble(), Y = r.Next(0, 2) == 0 ? 0 : 1 };
            }

            shape.ConnectionPoints = new DevExpress.Diagram.Core.DiagramPointCollection(points);
        }
    }
}
