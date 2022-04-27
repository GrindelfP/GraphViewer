using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GraphViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private short[] Id = new short[5];
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DrawCoordinateSystem();
        }

        private void DrawAxis(string mode)
        {
            if (mode == "X")
            {
                Line L = new();
                L.X1 = 0;
                L.X2 = Can.ActualWidth;
                L.Y1 = Can.ActualHeight / 2;
                L.Y2 = Can.ActualHeight / 2;
                L.Stroke = Brushes.Blue;
                Can.Children.Add(L);
            }
            else
            {
                Line L = new();
                L.X1 = Can.ActualWidth / 2;
                L.X2 = Can.ActualWidth / 2;
                L.Y1 = 0;
                L.Y2 = Can.ActualHeight;
                L.Stroke = Brushes.Blue;
                Can.Children.Add(L);
            }
        }

        private void DrawCoordinateSystem()
        {
            DrawAxis("X");
            DrawAxis("Y");

        }

        private void DrawGraph(string mode)
        {
            double h = Can.ActualHeight / 2;
            double w = Can.ActualWidth / 2;
            //double x0 = -w / 5;
            //double y0;
            //switch (mode)
            //{
            //    case "Cosinus":
            //        y0 = -Math.Cos(x0) * 35 + h;
            //        break;
            //    case "Sinus":
            //        y0 = -Math.Sin(x0) * 35 + h;
            //        break;
            //    case "Tangens":
            //        y0 = -Math.Tan(x0) * 5 + h;
            //        break;
            //    case "Parable":
            //        y0 = -(x0 * x0 + x0 + 1) * 5 + h;
            //        break;
            //    default:
            //        y0 = -(2 * x0 + 6 * x0 * x0 * x0) / Math.Sin(x0) + h;
            //        break;
            //}
            for (var x = -w / 5; x <= w / 5; x += 0.1)
            {
                double y;
                switch (mode)
                {
                    case "Cosinus":
                        Id[0] = 1;
                        y = -Math.Cos(x) * 35 + h;
                        break;
                    case "Sinus":
                        Id[1] = 1;
                        y = -Math.Sin(x) * 35 + h;
                        break;
                    case "Tangens":
                        Id[2] = 1;
                        y = -Math.Tan(x) * 5 + h;
                        break;
                    case "Parable":
                        Id[3] = 1;
                        y = -(x * x + x + 1) * 5 + h;
                        break;
                    default:
                        Id[4] = 1;
                        y = -(2 * x + 6 * x * x * x) / Math.Sin(x) + h;
                        break;
                }
                EllipseGeometry el = new();
                el.Center = new Point(x * 5 + w, y);
                el.RadiusX = 0.5;
                el.RadiusY = 2;
                Path p = new();
                p.Data = el;
                p.Fill = Brushes.Black;
                Can.Children.Add(p);
                //            LineGeometry line = new();
                //            line.StartPoint = new Point(x03 + w5, y03);
                //            line.EndPoint = new Point(x + w5, y);
                //            Path p = new();
                //            p.Data = line;
                //            p.Stroke = Brushes.Black;
                //            Can.Children.Add(p);
                //            x03 = x;
                //            y03 = y;

            }
        }

        private void DrawCosX_Click(object sender, RoutedEventArgs e)
        {
            DrawGraph("Cosinus");
        }
        private void DrawSinX_Click(object sender, RoutedEventArgs e)
        {
            DrawGraph("Sinus");
        }
        private void DrawTanX_Click(object sender, RoutedEventArgs e)
        {
            DrawGraph("Tangens");
        }
        private void DrawPar_Click(object sender, RoutedEventArgs e)
        {
            DrawGraph("Parable");
        }
        private void DrawComplex_Click(object sender, RoutedEventArgs e)
        {
            DrawGraph("Complex");
        }

        private void ClearField_Click(object sender, RoutedEventArgs e)
        {
            Can.Children.Clear();
            for (var i = 0; i < Id.Length; i++)
            {
                Id[i] = 0;
            }
            DrawCoordinateSystem();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Can.Children.Clear();

            if (Id[0] == 1)
            {
                DrawGraph("Cosinus");
            }
            
            if (Id[1] == 1)
            {
                DrawGraph("Sinus");
            }
            
            if (Id[2] == 1)
            {
                DrawGraph("Tangens");
            }
            
            if (Id[3] == 1)
            {
                DrawGraph("Parable");
            }

            if (Id[4] == 1)
            {
                DrawGraph("Complex");
            }
            
            DrawCoordinateSystem();
        }
    }
}
