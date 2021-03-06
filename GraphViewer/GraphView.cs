using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GraphViewer
{
    internal class GraphView : MainWindow
    {
        public readonly byte[] Id = new byte[5];

        public void DrawAxis(string mode)
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

        public void DrawCoordinateSystem()
        {
            DrawAxis("X");
            DrawAxis("Y");

        }
        public void DrawCos()
        {
            double h = Can.ActualHeight / 2;
            double w = Can.ActualWidth / 2;
            for (var x = -w / 5; x <= w / 5; x += 0.1)
            {
                Id[0] = 1;
                double y = -Math.Cos(x) * 35 + h;
                EllipseGeometry el = new();
                el.Center = new Point(x * 5 + w, y);
                el.RadiusX = 0.5;
                el.RadiusY = 2;
                Path p = new();
                p.Data = el;
                p.Fill = Brushes.Black;
                Can.Children.Add(p);
            }
        }
        public void DrawSin()
        {
            double h = Can.ActualHeight / 2;
            double w = Can.ActualWidth / 2;
            for (var x = -w / 5; x <= w / 5; x += 0.1)
            {
                Id[1] = 1;
                double y = -Math.Sin(x) * 35 + h;
                EllipseGeometry el = new();
                el.Center = new Point(x * 5 + w, y);
                el.RadiusX = 0.5;
                el.RadiusY = 2;
                Path p = new();
                p.Data = el;
                p.Fill = Brushes.Black;
                Can.Children.Add(p);
            }
        }
        public void DrawTan()
        {
            var h = Can.ActualHeight / 2;
            var w = Can.ActualWidth / 2;
            var x0 = -w / 5;
            var y0 = -(Math.Tan(x0)) * 5 + h;
            for (var x = -w / 5; x <= w / 5; x += 0.1)
            {
                Id[2] = 1;
                double y = -Math.Tan(x) * 5 + h;
                LineGeometry line = new();
                line.StartPoint = new Point(20 * x0 + w, y0);
                line.EndPoint = new Point(20 * x + w, y);
                Path p = new();
                p.Data = line;
                p.Stroke = Brushes.Black;
                Can.Children.Add(p);
                x0 = x;
                y0 = y;
            }
        }
        public void DrawParable()
        {
            var h = Can.ActualHeight / 2;
            var w = Can.ActualWidth / 2;
            var x0 = -w / 5;
            var y0 = -(x0 * x0 + x0 + 1) * 5 + h;
            for (var x = -w / 5; x <= w / 5; x += 0.1)
            {
                Id[3] = 1;
                double y = -(x * x + x + 1) * 5 + h;
                LineGeometry line = new();
                line.StartPoint = new Point(7 * x0 + w, y0);
                line.EndPoint = new Point(7 * x + w, y);
                Path p = new();
                p.Data = line;
                p.Stroke = Brushes.Black;
                Can.Children.Add(p);
                x0 = x;
                y0 = y;
            }
        }
        public void DrawComplexGraph()
        {
            var h = Can.ActualHeight / 2;
            var w = Can.ActualWidth / 2;
            var x0 = -w / 5;
            var y0 = -(2 * x0 + 6 * x0 * x0 * x0) / Math.Sin(x0) + Math.Tan(x0) + h;
            for (var x = -w / 5; x <= w / 5; x += 0.1)
            {
                Id[4] = 1;
                double y = -(2 * x + 6 * x * x * x) / Math.Sin(x) + Math.Tan(x) + h;
                LineGeometry line = new();
                line.StartPoint = new Point(5 * x0 + w, y0);
                line.EndPoint = new Point(5 * x + w, y);
                Path p = new();
                p.Data = line;
                p.Stroke = Brushes.Black;
                Can.Children.Add(p);
                x0 = x;
                y0 = y;
            }
        }
    }
}