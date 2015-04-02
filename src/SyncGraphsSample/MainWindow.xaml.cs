using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SyncGraphsSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            centerPlotter.(Enumerable.Range(1, 10));

            int N = 25;
            Random r = new Random();
            double[] x = new double[N];
            double[] y = new double[N];
            for (int i = 0; i < N; i++)
            {
                x[i] = r.NextDouble() * 12 - 1;
                y[i] = r.NextDouble() * 12 - 1;
            }
            circles.PlotXY(x, y);

            double[] x1 = Enumerable.Range(0, 90).Select(i => i / 10.0).ToArray();
            double[] y1 = x1.Select(v => 7 * (Math.Abs(v) < 1e-10 ? 1 : Math.Sin(v) / v) + 1).ToArray();
            lineGraph1.Stroke = new SolidColorBrush(Colors.Green);
            lineGraph1.StrokeThickness = 2.0;
            lineGraph1.Plot(x1, y1);

        }
    }
}
