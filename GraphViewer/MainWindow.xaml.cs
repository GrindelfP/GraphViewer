using System.Windows;

namespace GraphViewer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private readonly GraphView GraphView = new GraphView();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GraphView.DrawCoordinateSystem();
        }

        private void DrawCosX_Click(object sender, RoutedEventArgs e)
        {
            GraphView.DrawCos();
        }
        private void DrawSinX_Click(object sender, RoutedEventArgs e)
        {
            GraphView.DrawSin();
        }
        private void DrawTanX_Click(object sender, RoutedEventArgs e)
        {
            GraphView.DrawTan();
        }
        private void DrawPar_Click(object sender, RoutedEventArgs e)
        {
            GraphView.DrawParable();
        }
        private void DrawComplex_Click(object sender, RoutedEventArgs e)
        {
            GraphView.DrawComplexGraph();
        }

        private void ClearField_Click(object sender, RoutedEventArgs e)
        {
            Can.Children.Clear();
            for (var i = 0; i < GraphView.Id.Length; i++)
            {
                GraphView.Id[i] = 0;
            }
            GraphView.DrawCoordinateSystem();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Can.Children.Clear();

            if (GraphView.Id[0] == 1)
            {
                GraphView.DrawCos();
            }

            if (GraphView.Id[1] == 1)
            {
                GraphView.DrawSin();
            }

            if (GraphView.Id[2] == 1)
            {
                GraphView.DrawTan();
            }

            if (GraphView.Id[3] == 1)
            {
                GraphView.DrawParable();
            }

            if (GraphView.Id[4] == 1)
            {
                GraphView.DrawComplexGraph();
            }

            GraphView.DrawCoordinateSystem();
        }
    }
}
