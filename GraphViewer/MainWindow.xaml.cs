using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
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

        private void DrawAxisX()
        {
            Line X = new();
            X.X1 = 0;
            X.X2 = Can.ActualWidth;
            X.Y1 = Can.ActualHeight / 2;
            X.Y2 = Can.ActualHeight / 2;
            X.Stroke = Brushes.Blue;
            Can.Children.Add(X);
        }
        private void DrawAxisY()
        {
            Line Y = new();
            Y.X1 = Can.ActualWidth / 2;
            Y.X2 = Can.ActualWidth / 2;
            Y.Y1 = 0;
            Y.Y2 = Can.ActualHeight;
            Y.Stroke = Brushes.Blue;
            Can.Children.Add(Y);
        }
        public void DrawCosinus()
        {

            double h = Can.ActualHeight / 2;
            double w = Can.ActualWidth / 2;
            for (var x = -w / 5; x <= w / 5; x += 0.1)
            {
                double y = Math.Cos(x) * 35 + h;
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
        public void DrawSinus()
        {

            double h = Can.ActualHeight / 2;
            double w = Can.ActualWidth / 2;
            for (var x = -w / 5; x <= w / 5; x += 0.1)
            {
                double y = Math.Sin(x) * 35 + h;
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

        public void DrawTangens()
        {

            double h = Can.ActualHeight / 2;
            double w = Can.ActualWidth / 2;
            for (var x = -w / 5; x <= w / 5; x += 0.1)
            {
                double y = Math.Tan(x) * 5 + h;
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
        private void DrawParab()
        {
            double h = Can.ActualHeight / 2;
            double w = Can.ActualWidth / 2;
            for (var x = -w / 5; x <= w / 5; x += 0.1)
            {
                double y = -(x * x + x + 1) * 5 + h;
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

        private void DrawCosX_Click(object sender, RoutedEventArgs e)
        {
            DrawCosinus();
        }
        private void DrawSinX_Click(object sender, RoutedEventArgs e)
        {
            DrawSinus();
        }
        private void DrawTanX_Click(object sender, RoutedEventArgs e)
        {
            DrawTangens();
        }
        private void DrawPar_Click(object sender, RoutedEventArgs e)
        {
            DrawParab();
        }

        private void ClearField_Click(object sender, RoutedEventArgs e)
        {
            Can.Children.Clear();
            DrawAxisX();
            DrawAxisY();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DrawAxisX();
            DrawAxisY();
        }

    }
}
